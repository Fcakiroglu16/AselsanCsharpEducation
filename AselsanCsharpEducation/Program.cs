using System;

namespace AselsanCsharpEducation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberAsEmpty;
            //value types
            int number = 10;
            byte numberAsByte = 200;
            short numberAsShort = 100;
            long numberAsLong = 100;
            float numberFloat = 20.00f;
            double numberDouble = 10.00;
            decimal numberDecimal = 20.00m;
            DateTime currentDate = DateTime.Now;

            Console.WriteLine("number:" + number);

            Console.WriteLine($"number:{number}");
            //Console.WriteLine(`number:${number}`);
            Console.WriteLine("number:{0} {1}", number, numberAsByte);

            string rowProductName = "name:{0}";

            Console.WriteLine(rowProductName, "ahmet");


            //Console.WriteLine(numberAsEmpty);
        }
    }
}