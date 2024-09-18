using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AselsanCsharpEducation.Abstractions.Example
{
    internal class B : IB, IB1
    {
        public int Tax { get; set; }

        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add5(int a, int b, int c)
        {
            return a + b;
        }

        public int Sum(int a, int b)
        {
            return a + b;
        }
    }
}