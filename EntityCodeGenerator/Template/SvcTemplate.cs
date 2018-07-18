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
    internal class SvcTemplate : ITemplate
    {
        public SvcTemplate(EntityType entityType)
        {
            EntityType = entityType;
        }

        public string Directory
        {
            get
            {
                return TemplateCommon.svcDirectory;
            }
        }

        public EntityType EntityType { get; set; }

        public string Namespace
        {
            get
            {
                return TemplateCommon.svcNamespace;
            }
        }

        public void Generator(EntityModelSchemaGenerator modelGenerator, TemplateProcessor templateProcessor, EdmMapping mappings)
        {
            var entityName = EntityType.Name.RemoveSpecialChar();
            var svcHost = new EfTextTemplateHost
            {
                EntityType = EntityType,
                EntityContainer = modelGenerator.EntityContainer,
                Namespace = TemplateCommon.svcNamespace,
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
            var svcContents = templateProcessor.Process(Templates.SvcTemplate, svcHost);

            var svcPath = Path.Combine(Directory, entityName + "Svc" + svcHost.FileExtension);
            FileGenerator.AddNewFile(svcPath, svcContents);

        }
    }
}
