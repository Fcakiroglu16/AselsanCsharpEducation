using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace AselsanCsharpEducation.Generic
{
    public class Client
    {
        void X()
        {
            Editor editor = new Editor();
            Manager manager = new Manager();
        }
    }

    public class CalculateGeneric
    {
        //public T Add<T>(T a, T b)
        //{
        //    if (a is int aAsInt && b is int bInt)
        //    {
        //        var sum= aAsInt + bInt;

        //    }
        //}
    }

    public class Calculate
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }
    }


    internal class PersonBase<T, T2>
    {
        public T Id { get; set; }
        public T2 Price { get; set; }


        public T Add(T a, T b)
        {
            return a;
        }
    }

    internal class Editor : PersonBase<int, double>
    {
        public string Name { get; set; }
    }

    internal class Manager : PersonBase<string, decimal>
    {
        public string Name { get; set; }
    }
}