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
    internal class ContextTemplate : ITemplate
    {
        public ContextTemplate()
        {
        }

        public string Directory
        {
            get
            {
                return TemplateCommon.modelsDirectory;
            }
        }

        public EntityType EntityType { get; set; }

        public string Namespace
        {
            get
            {
                return TemplateCommon.modelsNamespace;
            }
        }

        public void Generator(EntityModelSchemaGenerator modelGenerator, TemplateProcessor templateProcessor, EdmMapping mappings)
        {
            var contextHost = new EfTextTemplateHost
            {
                EntityContainer = modelGenerator.EntityContainer,
                Namespace = TemplateCommon.modelsNamespace,
                ModelsNamespace = TemplateCommon.modelsNamespace,
                MappingNamespace = TemplateCommon.mappingNamespace,
                EntityFrameworkVersion = TemplateCommon.entityFrameworkVersion
            };
            var contextContents = templateProcessor.Process(Templates.ContextTemplate, contextHost);

            var contextFilePath = Path.Combine(Directory, modelGenerator.EntityContainer.Name + contextHost.FileExtension);
            FileGenerator.AddNewFile(contextFilePath, contextContents);
        }
    }
}
