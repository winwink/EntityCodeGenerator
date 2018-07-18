using Microsoft.CSharp;
using System;
using System.Collections.Generic;
using System.Data.Metadata.Edm;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Microsoft.DbContextPackage.Utilities
{
    public class CodeGenerationToolsForK2
    {
        private static Dictionary<string, SoType> _mapping = new Dictionary<string, SoType>();
        private readonly DynamicTextTransformation _textTransformation;
        private readonly CSharpCodeProvider _code;
        private readonly MetadataTools _ef;

        static CodeGenerationToolsForK2()
        {
            _mapping.Add("string", SoType.Text);
            _mapping.Add("int16", SoType.Number);
            _mapping.Add("int32", SoType.Number);
            _mapping.Add("int64", SoType.Number);
            _mapping.Add("decimal", SoType.Decimal);
            _mapping.Add("boolean", SoType.YesNo);
            _mapping.Add("datetime", SoType.DateTime);
            _mapping.Add("double", SoType.Decimal);
            _mapping.Add("float", SoType.Decimal);
            _mapping.Add("single", SoType.Decimal);
            _mapping.Add("timespan", SoType.Time);
        }

        public CodeGenerationToolsForK2(object textTransformation)
        {
            if (textTransformation == null)
            {
                throw new ArgumentNullException("textTransformation");
            }

            _textTransformation = DynamicTextTransformation.Create(textTransformation);
            _code = new CSharpCodeProvider();
            _ef = new MetadataTools(_textTransformation);
        }

        public string Escape(TypeUsage typeUsage)
        {
            if (typeUsage == null)
            {
                return null;
            }

            if (typeUsage.EdmType is ComplexType ||
                typeUsage.EdmType is EntityType)
            {
                return Escape(typeUsage.EdmType.Name);
            }
            else if (typeUsage.EdmType is PrimitiveType)
            {

                Type clrType = _ef.ClrType(typeUsage);
                string typeName = Escape(clrType);

                return typeName;
            }
            else if (typeUsage.EdmType is CollectionType)
            {
                return String.Format(CultureInfo.InvariantCulture, "ICollection<{0}>", Escape(((CollectionType)typeUsage.EdmType).TypeUsage));
            }


            throw new ArgumentException("typeUsage");
        }

        /// <summary>
        /// Returns a string that is safe for use as an identifier in C#.
        /// Keywords are escaped.
        /// </summary>
        public string Escape(string name)
        {
            if (name == null)
            {
                return null;
            }

            return _code.CreateEscapedIdentifier(name);
        }
        
        public static string Escape(Type clrType)
        {
            var type = clrType;
            if(clrType.IsGenericType)
            {
                type = clrType.GetGenericArguments()[0];
            }
            var result = "";
            var typeName = type.Name.ToLower();
            if (_mapping.ContainsKey(typeName))
            {
                result = _mapping[typeName].ToString();
            }
            
            return result;
        }
    }

    public enum SoType
    {
        Text = 0,
        Memo = 1,
        Number = 2,
        Decimal = 3,
        Autonumber = 4,
        YesNo = 5,
        DateTime = 6,
        Image = 7,
        File = 8,
        MultiValue = 9,
        Xml = 10,
        Default = 11,
        HyperLink = 12,
        Guid = 13,
        AutoGuid = 14,
        Date = 15,
        Time = 16
    }
}
