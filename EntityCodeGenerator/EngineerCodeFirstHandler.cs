// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.
namespace EntityCodeGenerator
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Data.Common;
    using System.Data.Entity.Design;
    using System.Data.Entity.Design.PluralizationServices;
    using System.Data.Metadata.Edm;
    using System.Data.SqlClient;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml;
    using Microsoft.DbContextPackage.Utilities;
    using Template;

    internal class EngineerCodeFirstHandler
    {
        private static readonly IEnumerable<EntityStoreSchemaFilterEntry> _storeMetadataFilters = new[]
            {
                new EntityStoreSchemaFilterEntry(null, null, "EdmMetadata", EntityStoreSchemaFilterObjectTypes.Table, EntityStoreSchemaFilterEffect.Exclude),
                new EntityStoreSchemaFilterEntry(null, null, "__MigrationHistory", EntityStoreSchemaFilterObjectTypes.Table, EntityStoreSchemaFilterEffect.Exclude)
            };


        public void ReverseEngineerCodeFirst()
        {
            try
            {
                // Find connection string and provider
                string connectionString = "data source=172.21.4.31,10086;initial catalog=Eme4;user id=eme;password=io77@68;MultipleActiveResultSets=True;App=EntityFramework&quot;";
                var providerInvariant = "System.Data.SqlClient";
                string projectNamespace = "TEST";
                string currentDirectory = System.IO.Directory.GetCurrentDirectory();

                DbConnection connection = new SqlConnection(connectionString);

                // Load store schema
                var storeGenerator = new EntityStoreSchemaGenerator(providerInvariant, connectionString, "dbo");
                storeGenerator.GenerateForeignKeyProperties = true;
                var errors = storeGenerator.GenerateStoreMetadata(_storeMetadataFilters).Where(e => e.Severity == EdmSchemaErrorSeverity.Error);


                // Generate default mapping

                var contextName = connection.Database.Replace(" ", string.Empty).Replace(".", string.Empty) + "Context";
                var modelGenerator = new EntityModelSchemaGenerator(storeGenerator.EntityContainer, "DefaultNamespace", contextName);
                modelGenerator.PluralizationService = PluralizationService.CreateService(new CultureInfo("en"));
                modelGenerator.GenerateForeignKeyProperties = true;
                modelGenerator.GenerateMetadata();

                // Pull out info about types to be generated
                var entityTypes = modelGenerator.EdmItemCollection.OfType<EntityType>().ToArray();
                var mappings = new EdmMapping(modelGenerator, storeGenerator.StoreItemCollection);


                // Generate Entity Classes and Mappings
                var templateProcessor = new TemplateProcessor();
                var modelsNamespace = projectNamespace + ".Models";
                var modelsDirectory = Path.Combine(currentDirectory, "Models");
                var mappingNamespace = modelsNamespace + ".Mapping";
                var mappingDirectory = Path.Combine(modelsDirectory, "Mapping");
                var entityFrameworkVersion = GetEntityFrameworkVersion();

                foreach (var entityType in entityTypes)
                {
                    // Generate the code file
                    var entityHost = new EfTextTemplateHost
                    {
                        EntityType = entityType,
                        EntityContainer = modelGenerator.EntityContainer,
                        Namespace = modelsNamespace,
                        ModelsNamespace = modelsNamespace,
                        MappingNamespace = mappingNamespace,
                        EntityFrameworkVersion = entityFrameworkVersion,
                        TableSet = mappings.EntityMappings[entityType].Item1,
                        PropertyToColumnMappings = mappings.EntityMappings[entityType].Item2,
                        ManyToManyMappings = mappings.ManyToManyMappings
                    };
                    var entityContents = templateProcessor.Process(Templates.EntityTemplate, entityHost);

                    var filePath = Path.Combine(modelsDirectory, entityType.Name + entityHost.FileExtension);
                    FileGenerator.AddNewFile(filePath, entityContents);

                    var mappingHost = new EfTextTemplateHost
                    {
                        EntityType = entityType,
                        EntityContainer = modelGenerator.EntityContainer,
                        Namespace = mappingNamespace,
                        ModelsNamespace = modelsNamespace,
                        MappingNamespace = mappingNamespace,
                        EntityFrameworkVersion = entityFrameworkVersion,
                        TableSet = mappings.EntityMappings[entityType].Item1,
                        PropertyToColumnMappings = mappings.EntityMappings[entityType].Item2,
                        ManyToManyMappings = mappings.ManyToManyMappings
                    };
                    var mappingContents = templateProcessor.Process(Templates.MappingTemplate, mappingHost);

                    var mappingFilePath = Path.Combine(mappingDirectory, entityType.Name + "Map" + mappingHost.FileExtension);
                    FileGenerator.AddNewFile(filePath, entityContents);
                }

                // Generate Context

                var contextHost = new EfTextTemplateHost
                {
                    EntityContainer = modelGenerator.EntityContainer,
                    Namespace = modelsNamespace,
                    ModelsNamespace = modelsNamespace,
                    MappingNamespace = mappingNamespace,
                    EntityFrameworkVersion = entityFrameworkVersion
                };
                var contextContents = templateProcessor.Process(Templates.ContextTemplate, contextHost);

                var contextFilePath = Path.Combine(modelsDirectory, modelGenerator.EntityContainer.Name + contextHost.FileExtension);
                FileGenerator.AddNewFile(contextFilePath, contextContents);


            }
            catch (Exception exception)
            {

            }
        }


        public void CodeGenerator(string connectionString, string projectNamespace, Action<string> action, List<string> selectedTables)
        {
            try
            {
                // Find connection string and provider
                var providerInvariant = "System.Data.SqlClient";
                string currentDirectory = System.IO.Directory.GetCurrentDirectory();

                using (DbConnection connection = new SqlConnection(connectionString))
                {
                    // Load store schema
                    var storeGenerator = new EntityStoreSchemaGenerator(providerInvariant, connectionString, "dbo");
                    storeGenerator.GenerateForeignKeyProperties = true;
                    var errors = storeGenerator.GenerateStoreMetadata(_storeMetadataFilters).Where(e => e.Severity == EdmSchemaErrorSeverity.Error);

                    // Generate default mapping
                    var contextName = connection.Database.Replace(" ", string.Empty).Replace(".", string.Empty) + "Context";
                    var modelGenerator = new EntityModelSchemaGenerator(storeGenerator.EntityContainer, "DefaultNamespace", contextName);
                    modelGenerator.PluralizationService = PluralizationService.CreateService(new CultureInfo("en"));
                    modelGenerator.GenerateForeignKeyProperties = true;
                    modelGenerator.GenerateMetadata();

                    // Pull out info about types to be generated
                    var entityTypes = modelGenerator.EdmItemCollection.OfType<EntityType>().ToArray().ToList();

                    var mappings = new EdmMapping(modelGenerator, storeGenerator.StoreItemCollection);
                    var templateProcessor = new TemplateProcessor();


                    entityTypes = HandleCompletedRun(entityTypes, selectedTables);

                    TemplateCommon.projectNamespace = projectNamespace;
                    TemplateCommon.entityFrameworkVersion = GetEntityFrameworkVersion();
                    TemplateCommon.Init();
                    foreach (var entityType in entityTypes)
                    {
                        var entityName = entityType.Name.RemoveSpecialChar();

                        EntityTemplate entityTemplate = new EntityTemplate(entityType);
                        entityTemplate.Generator(modelGenerator, templateProcessor, mappings);

                        // Generate the map file
                        new MappingTemplate(entityType).Generator(modelGenerator, templateProcessor, mappings);

                        //Generate the repository file
                        new RepositoryTemplate(entityType).Generator(modelGenerator, templateProcessor, mappings);

                        //Generate the service file
                        new ServiceTemplate(entityType).Generator(modelGenerator, templateProcessor, mappings);

                        //Generate the svc file
                        new SvcTemplate(entityType).Generator(modelGenerator, templateProcessor, mappings);

                        //Generate the svc test file
                        new SvcTestTemplate(entityType).Generator(modelGenerator, templateProcessor, mappings);
                    }

                    // Generate Context
                    new ContextTemplate().Generator(modelGenerator, templateProcessor, mappings);

                    if (action != null)
                    {
                        action("代码生成成功");
                    }

                }
            }
            catch (Exception exception)
            {
                if (action != null)
                {
                    action(exception.Message);
                }
            }
        }

        private List<EntityType> HandleCompletedRun(List<EntityType> list, List<string> selectedTables)
        {
            List<EntityType> result = new List<EntityType>(list);
            if (selectedTables.Count > 0)
            {
                result = list.Where(m => selectedTables.Contains(m.Name)).ToList();
            }
                
            
            return result;
        }


        private static Version GetEntityFrameworkVersion()
        {
            return new Version("6.0.0.0");
        }


        private static string FixUpConnectionString(string connectionString, string providerName)
        {


            if (providerName != "System.Data.SqlClient")
            {
                return connectionString;
            }

            var builder = new SqlConnectionStringBuilder(connectionString)
            {
                MultipleActiveResultSets = true
            };
            builder.Remove("Pooling");

            return builder.ToString();
        }


    }
}
