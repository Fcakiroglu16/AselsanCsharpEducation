using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 20;
            var b = 10;

            var calculate = new Calculate();

            Console.WriteLine(calculate.Divide(a, b));
        }
    }
}