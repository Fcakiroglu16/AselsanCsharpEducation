using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AselsanCsharpEducation.ExtensionMethod
{
    internal static class ExtensionMethod
    {
        public static string GetFirstCharacter(this string value)
        {
            return value.Substring(0, 1);
        }


        public static string GetEngineAndGearBox(this Car car)
        {
            return $"{car.Engine} - {car.GearBox}";
        }
    }
}