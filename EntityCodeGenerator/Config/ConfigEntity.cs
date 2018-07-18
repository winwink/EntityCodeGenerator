using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;
using Jieysoft.Common;

namespace EntityCodeGenerator.Config
{
    public class ConfigEntity
    {
        public ConfigEntity()
        {

        }

        public ConfigEntity(string tableName)
        {
            TableName = tableName;
        }
        
        public string TableName { get; set; }

        public XElement ToXElement()
        {
            XElement xle = new XElement("ConfigEntity",new XAttribute("TableName",TableName));
            return xle;
        }

        public void Parse(XElement xle)
        {
            TableName = xle.AttributeValue("TableName");
        }
    }
    
    public class ConfigEntityCollection
    {
        public List<ConfigEntity> List { get; set; } = new List<ConfigEntity>();

        public static readonly string SavePath = Path.Combine(Environment.CurrentDirectory, "ConfigEntity.xml");

        public XElement ToXElement()
        {
            XElement xle = new XElement("ConfigEntityCollection");
            foreach(var item in List)
            {
                xle.Add(item.ToXElement());
            }
            return xle;
        }

        public void Parse(XElement xle)
        {
            List.Clear();
            foreach(XElement entityXle in xle.Elements())
            {
                ConfigEntity entity = new ConfigEntity();
                entity.Parse(entityXle);
                List.Add(entity);
            }
        }

        public void Save()
        {
            var xle = ToXElement();
            xle.Save(SavePath);
        }

        public void Load()
        {
            var xle = XElement.Load(SavePath);
            Parse(xle);
        }
    }
}
