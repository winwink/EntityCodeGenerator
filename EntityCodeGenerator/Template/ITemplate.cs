using Microsoft.DbContextPackage.Utilities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Design;
using System.Data.Metadata.Edm;
using System.IO;
using System.Linq;
using System.Text;
using static EntityCodeGenerator.EngineerCodeFirstHandler;

namespace EntityCodeGenerator.Template
{
    internal interface ITemplate
    {
       string Namespace { get; }

       string Directory { get; }

       EntityType EntityType { get; set; }
       
       void Generator(EntityModelSchemaGenerator modelGenerator, TemplateProcessor templateProcessor, EdmMapping mappings);
    }

    public class TemplateCommon
    {
        public static string projectNamespace = "";
        public static Version entityFrameworkVersion;
        public static string modelsNamespace = "";
        public static string modelsDirectory = "";
        public static string mappingNamespace = "";
        public static string mappingDirectory = "";
        public static string repositoryNamespace = "";
        public static string repositoryDirectory = "";
        public static string repositoryBaseNamespace = "";
        public static string serviceNamespace = "";
        public static string coreNamespace = "";
        public static string serviceDirectory = "";
        public static string svcNamespace = "";
        public static string svcDirectory = "";

        public static void Init()
        {
            var currentDirectory = Environment.CurrentDirectory;
            modelsNamespace = projectNamespace + ".Entity";
            modelsDirectory = Path.Combine(currentDirectory, "Entity");
            mappingNamespace = modelsNamespace + ".Mapping";
            mappingDirectory = Path.Combine(modelsDirectory, "Mapping");
            repositoryNamespace = projectNamespace + ".Repository";
            repositoryDirectory = Path.Combine(currentDirectory, "Repository");
            repositoryBaseNamespace = projectNamespace + ".RepositoryBase";
            serviceNamespace = projectNamespace + ".Services";
            coreNamespace = projectNamespace + ".Core";
            serviceDirectory = Path.Combine(currentDirectory, "Services");

            svcNamespace = projectNamespace + ".Svc";
            svcDirectory = Path.Combine(currentDirectory, "Svc");
        }
    }
}
