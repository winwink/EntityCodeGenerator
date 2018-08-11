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
    internal class RepositoryTemplate : ITemplate
    {
        public RepositoryTemplate(EntityType entityType)
        {
            EntityType = entityType;
        }

        public string Directory
        {
            get
            {
                return TemplateCommon.repositoryDirectory;
            }
        }

        public EntityType EntityType { get; set; }

        public string Namespace
        {
            get
            {
                return TemplateCommon.repositoryNamespace;
            }
        }

        public void Generator(EntityModelSchemaGenerator modelGenerator, TemplateProcessor templateProcessor, EdmMapping mappings)
        {
            var entityName = EntityType.Name.RemoveSpecialChar();
            var repoHost = new EfTextTemplateHost
            {
                EntityType = EntityType,
                EntityContainer = modelGenerator.EntityContainer,
                Namespace = TemplateCommon.repositoryNamespace,
                ModelsNamespace = TemplateCommon.modelsNamespace,
                MappingNamespace = TemplateCommon.mappingNamespace,
                RepositoryBaseNamespace = TemplateCommon.repositoryBaseNamespace,
                RepositoryNamespace = TemplateCommon.repositoryNamespace,
                EntityFrameworkVersion = TemplateCommon.entityFrameworkVersion,
                TableSet = mappings.EntityMappings[EntityType].Item1,
                PropertyToColumnMappings = mappings.EntityMappings[EntityType].Item2,
                ManyToManyMappings = mappings.ManyToManyMappings,
                EntityName = entityName
            };
            var repositoryContents = templateProcessor.Process(Templates.RepositoryTemplate, repoHost);

            var repositoryPath = Path.Combine(Directory, entityName + "Repository" + repoHost.FileExtension);
            FileGenerator.AddNewFile(repositoryPath, repositoryContents);

        }
    }
}
