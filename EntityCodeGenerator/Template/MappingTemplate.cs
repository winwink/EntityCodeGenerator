using System;
using System.Collections.Generic;
using System.Data.Entity.Design;
using System.Data.Metadata.Edm;
using System.Linq;
using System.Text;
using Microsoft.DbContextPackage.Utilities;
using System.IO;

namespace EntityCodeGenerator.Template
{
    internal class MappingTemplate : ITemplate
    {
        public MappingTemplate(EntityType entityType)
        {
            EntityType = entityType;
        }

        public string Directory
        {
            get
            {
                return Path.Combine(new EntityTemplate(EntityType).Directory, "Mapping");
            }
        }

        public EntityType EntityType { get; set; }

        public string Namespace
        {
            get
            {
                return new EntityTemplate(EntityType).EntityType + ".Mapping";
            }
        }

        public void Generator(EntityModelSchemaGenerator modelGenerator, TemplateProcessor templateProcessor, EdmMapping mappings)
        {
            var entityName = EntityType.Name.RemoveSpecialChar();
            var mappingHost = new EfTextTemplateHost
            {
                EntityType = EntityType,
                EntityContainer = modelGenerator.EntityContainer,
                Namespace = TemplateCommon.mappingNamespace,
                ModelsNamespace = TemplateCommon.modelsNamespace,
                MappingNamespace = TemplateCommon.mappingNamespace,
                EntityFrameworkVersion = TemplateCommon.entityFrameworkVersion,
                TableSet = mappings.EntityMappings[EntityType].Item1,
                PropertyToColumnMappings = mappings.EntityMappings[EntityType].Item2,
                ManyToManyMappings = mappings.ManyToManyMappings,
                EntityName = entityName
            };
            var mappingContents = templateProcessor.Process(Templates.MappingTemplate, mappingHost);

            var mappingFilePath = Path.Combine(TemplateCommon.mappingDirectory, entityName + "Map" + mappingHost.FileExtension);
            FileGenerator.AddNewFile(mappingFilePath, mappingContents);
        }
    }
}
