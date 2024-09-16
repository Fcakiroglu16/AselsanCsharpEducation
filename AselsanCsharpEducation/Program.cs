using System;

namespace AselsanCsharpEducation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pen pen = new Pen
            {
                Brand = "Faber Castell",
                Color = "Red",
                Model = "123",
            };

            pen.Write();
            //1.way
            Console.WriteLine($"tuple 1.data :{pen.ReturnTuple().Item1}");
            Console.WriteLine($"tuple 1.data :{pen.ReturnTuple().Item2}");
            //2.way
            var priceWithTax = pen.CalculateKdv(100, out int taxValue);
            Console.WriteLine($"priceWithTax:{priceWithTax}");
            Console.WriteLine($"taxvalue:{taxValue}");

            Console.WriteLine("-------------------------");
            Pen pen2 = new Pen
            {
                Brand = "Faber Castell",
                Color = "Red",
                Model = "123",
                Price = 10.00m,
                Height = 10,
                Width = 5
            };
            pen2.Write();

            #region value types

            //int numberAsEmpty;
            ////value types
            //int number = 10;
            //byte numberAsByte = 200;
            //short numberAsShort = 100;
            //long numberAsLong = 100;
            //float numberFloat = 20.00f;
            //double numberDouble = 10.00;
            //decimal numberDecimal = 20.00m;
            //DateTime currentDate = DateTime.Now;

            //Console.WriteLine("number:" + number);

            //Console.WriteLine($"number:{number}");
            ////Console.WriteLine(`number:${number}`);
            //Console.WriteLine("number:{0} {1}", number, numberAsByte);

            //string rowProductName = "name:{0}";

            //Console.WriteLine(rowProductName, "ahmet");

            //Console.WriteLine("numberAsByte:" + numberAsByte);

            //Console.WriteLine("Merhaba Dünya");

            //Console.WriteLine(numberAsEmpty);

            #endregion
        }
    }
}