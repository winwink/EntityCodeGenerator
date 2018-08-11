using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Jieysoft.Common
{
    public static class XElementExtension
    {
        public static string AttributeValue(this XElement element, string attrName)
        {
            if (string.IsNullOrWhiteSpace(attrName))
            {
                return "";
            }
            else
            {
                var attr = element.Attribute(attrName);
                if (attr != null)
                {
                    return attr.Value;
                }
                else
                {
                    return "";
                }
            }
        }

        public static string ElementValue(this XElement element, string sonElementName)
        {
            if (string.IsNullOrWhiteSpace(sonElementName))
            {
                return "";
            }
            else
            {
                var sonElementXle = element.Element(sonElementName);
                if (sonElementXle != null)
                {
                    return sonElementXle.Value;
                }
                else
                {
                    return "";
                }
            }
        }
    }
}
