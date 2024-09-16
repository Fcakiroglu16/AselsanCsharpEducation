using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace AselsanCsharpEducation
{
    internal class Pen
    {
        // public
        //internal
        //Private
        //field
        internal string Color;
        internal string Brand;
        internal string Model;
        internal decimal Price;
        internal int Height;
        internal int Width;
        internal DateTime Created;


        //Constructors

        internal Pen()
        {
            Created = DateTime.Now;
            Height = 20;
            Width = 30;
            Price = 100;
        }


        internal void Write()
        {
            Console.WriteLine($"Color:{Color}");
            Console.WriteLine($"Brand:{Brand}");
            Console.WriteLine($"Model:{Model}");
            Console.WriteLine($"Price:{Price}");
            Console.WriteLine($"Height:{Height}");
            Console.WriteLine($"Width:{Width}");
            Console.WriteLine($"Created:{Created}");
        }

        internal void WriteToConsole(string messageFromCache)
        {
            Console.WriteLine(messageFromCache);
        }

        internal string WriteToConsole()
        {
            return $"{Color}- {Brand}";
        }

        internal Tuple<string, string> ReturnTuple()
        {
            return new Tuple<string, string>(Color, Brand);
        }

        internal decimal CalculateKdv(decimal price, out int tax)
        {
            tax = 18;
            return price * 1.18m;
        }
    }
}