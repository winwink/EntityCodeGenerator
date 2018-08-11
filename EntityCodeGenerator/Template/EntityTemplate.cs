using System;
using System.Collections.Generic;
using System.Data.Entity.Design;
using System.Linq;
using System.Text;
using Microsoft.DbContextPackage.Utilities;
using System.IO;
using System.Data.Metadata.Edm;
using static EntityCodeGenerator.EngineerCodeFirstHandler;

namespace EntityCodeGenerator.Template
{
    internal class EntityTemplate : ITemplate
    { 
        public EntityTemplate(EntityType entityType)
        {
            EntityType = entityType;
        }

        public string Namespace
        {
            get
            {
                return TemplateCommon.projectNamespace + ".Entity";
            }
        }
        public string Directory
        {
            get
            {
                return Path.Combine(Environment.CurrentDirectory, "Entity");
            }
        }

        public EntityType EntityType { get; set; }

        public void Generator(EntityModelSchemaGenerator modelGenerator, TemplateProcessor templateProcessor, EdmMapping mappings)
        {
            var entityName = EntityType.Name.RemoveSpecialChar();
            // Generate the entity file
            var entityHost = new EfTextTemplateHost
            {
                EntityType = EntityType,
                EntityContainer = modelGenerator.EntityContainer,
                Namespace = Namespace,
                ModelsNamespace = Namespace,
                MappingNamespace = TemplateCommon.mappingNamespace,
                EntityFrameworkVersion =TemplateCommon.entityFrameworkVersion,
                TableSet = mappings.EntityMappings[EntityType].Item1,
                PropertyToColumnMappings = mappings.EntityMappings[EntityType].Item2,
                ManyToManyMappings = mappings.ManyToManyMappings,
                EntityName = entityName
            };
            var entityContents = templateProcessor.Process(Templates.EntityTemplate, entityHost);

            var filePath = Path.Combine(Directory, entityName + entityHost.FileExtension);
            FileGenerator.AddNewFile(filePath, entityContents);

        }
    }
}
