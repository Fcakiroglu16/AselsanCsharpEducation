using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AselsanCsharpEducation
{
    internal class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public static int Tax { get; set; } = 20;

        public Product()
        {
        }

        static Product()
        {
        }

        //static method
        public static int CalculateAsStatic(int a, int b)
        {
            return a + b;
        }

        //Instance method
        public int CalculateAsInstance(int a, int b)
        {
            return a + b;
        }
    }
}