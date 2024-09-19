using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AselsanCsharpEducation.ExtensionMethod
{
    internal class Helper
    {
        public static string GetFirstCharacter(string value)
        {
            return value.Substring(0, 1);
        }
    }
}