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
    internal class ServiceTemplate:ITemplate
    {
        public ServiceTemplate(EntityType entityType)
        {
            EntityType = entityType;
        }

        public string Directory
        {
            get
            {
                return TemplateCommon.serviceDirectory;
            }
        }

        public EntityType EntityType { get; set; }

        public string Namespace
        {
            get
            {
                return TemplateCommon.serviceNamespace;
            }
        }

        public void Generator(EntityModelSchemaGenerator modelGenerator, TemplateProcessor templateProcessor, EdmMapping mappings)
        {
            var entityName = EntityType.Name.RemoveSpecialChar();
            var serviceHost = new EfTextTemplateHost
            {
                EntityType = EntityType,
                EntityContainer = modelGenerator.EntityContainer,
                Namespace = TemplateCommon.serviceNamespace,
                ModelsNamespace = TemplateCommon.modelsNamespace,
                MappingNamespace = TemplateCommon.mappingNamespace,
                RepositoryBaseNamespace = TemplateCommon.repositoryBaseNamespace,
                CoreNamespace = TemplateCommon.coreNamespace,
                RepositoryNamespace = TemplateCommon.repositoryNamespace,
                EntityFrameworkVersion = TemplateCommon.entityFrameworkVersion,
                TableSet = mappings.EntityMappings[EntityType].Item1,
                PropertyToColumnMappings = mappings.EntityMappings[EntityType].Item2,
                ManyToManyMappings = mappings.ManyToManyMappings,
                EntityName = entityName
            };
            var serviceContents = templateProcessor.Process(Templates.ServiceTemplate, serviceHost);

            var servicePath = Path.Combine(Directory, entityName + "Service" + serviceHost.FileExtension);
            FileGenerator.AddNewFile(servicePath, serviceContents);
        }
    }
}
