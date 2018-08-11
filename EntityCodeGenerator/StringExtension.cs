using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityCodeGenerator
{
    public static class StringExtension
    {
        public static readonly string SpecialString = "_";
        public static string RemoveSpecialChar(this string str)
        {
            var result = str;
            foreach(char c in SpecialString)
            {
                result = result.Replace(c.ToString(), "");
            }
            return result;
        }
    }
}
