using Microsoft.DbContextPackage.Utilities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Design;
using System.Data.Metadata.Edm;
using System.IO;
using System.Linq;
using System.Text;

namespace EntityCodeGenerator.Template
{
    internal class SvcTestTemplate : ITemplate
    {
        public SvcTestTemplate(EntityType entityType)
        {
            EntityType = entityType;
        }

        public string Directory
        {
            get
            {
                return TemplateCommon.svcTestDirectory;
            }
        }

        public EntityType EntityType { get; set; }

        public string Namespace
        {
            get
            {
                return TemplateCommon.svcTestNamespace;
            }
        }

        public void Generator(EntityModelSchemaGenerator modelGenerator, TemplateProcessor templateProcessor, EdmMapping mappings)
        {
            var entityName = EntityType.Name.RemoveSpecialChar();
            var svcTestHost = new EfTextTemplateHost
            {
                EntityType = EntityType,
                EntityContainer = modelGenerator.EntityContainer,
                Namespace = TemplateCommon.svcTestNamespace,
                ModelsNamespace = TemplateCommon.modelsNamespace,
                MappingNamespace = TemplateCommon.mappingNamespace,
                RepositoryBaseNamespace = TemplateCommon.repositoryBaseNamespace,
                CoreNamespace = TemplateCommon.coreNamespace,
                RepositoryNamespace = TemplateCommon.repositoryNamespace,
                ServiceNamespace = TemplateCommon.serviceNamespace,
                SvcNamespace = Namespace,
                EntityFrameworkVersion = TemplateCommon.entityFrameworkVersion,
                TableSet = mappings.EntityMappings[EntityType].Item1,
                PropertyToColumnMappings = mappings.EntityMappings[EntityType].Item2,
                ManyToManyMappings = mappings.ManyToManyMappings,
                EntityName = entityName
            };
            var svcTestContents = templateProcessor.Process(Templates.SvcTestTemplate, svcTestHost);

            var svcTestPath = Path.Combine(Directory, entityName + "SvcTest" + svcTestHost.FileExtension);
            FileGenerator.AddNewFile(svcTestPath, svcTestContents);

        }
    }
}
