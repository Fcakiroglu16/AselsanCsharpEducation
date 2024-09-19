using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AselsanCsharpEducation.Delegates
{
    internal class DelegateExample
    {
        public int X { get; set; }


        public delegate void AddDelegate(int a, int b);


        public void Work()
        {
            var x = 10;
            var y = 20;
            bool isTrue = true;

            var calculateDelegate = new AddDelegate(Add);
            calculateDelegate += Sub;
            calculateDelegate += Multiply;
            calculateDelegate += Divide;

            if (isTrue == true)
            {
                calculateDelegate -= Multiply;
            }


            calculateDelegate(x, y);
        }


        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public void Sub(int a, int b)

        {
            Console.WriteLine(a - b);
        }

        public void Multiply(int a, int b)
        {
            Console.WriteLine(a * b);
        }

        public void Divide(int a, int b)
        {
            Console.WriteLine(a / b);
        }
    }
}