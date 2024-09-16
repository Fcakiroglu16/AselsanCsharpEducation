using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AselsanCsharpEducation
{
    public class ServiceResult
    {
        public string Err { get; set; }
        public object Data { get; set; }
    }

    public class ConvertType
    {
        public void CastTypeMethod()
        {
            int x = 2;

            object o = x; // boxing

            int y = (int)o; // unboxing


            //Implicit Cast
            int a = 5;

            double b = a;

            //Explicit Cast
            double c = 5.5;
            int d = (int)c;

            //Convert
            string str = "5";
            int e = Convert.ToInt32(str);

            //Parse
            string str2 = "5";
            int f = int.Parse(str);

            //TryParse
            string str3 = "5";
            int g;
            bool result = int.TryParse(str3, out g);
            if (result)
            {
                Console.WriteLine("Success");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }


        public (int add, string err) Sum(string a, string b)
        {
            if (int.TryParse(a, out int x) == false)
            {
                return (0, "First parameter is not a number");
            }

            if (int.TryParse(b, out int y) == false)
            {
                return (0, "Second parameter is not a number");
            }


            return (x + y, "");

            //int x = int.Parse(a);
            //int y = int.Parse(b);
            //int x = Convert.ToInt32(a);
            //int y = Convert.ToInt32(b);
        }

        public int Sum2(string a, string b)
        {
            if (int.TryParse(a, out int x) == false)
            {
                throw new Exception("First parameter is not a number");
            }

            if (int.TryParse(b, out int y) == false)
            {
                throw new Exception("Second parameter is not a number");
            }


            return x + y;

            //int x = int.Parse(a);
            //int y = int.Parse(b);
            //int x = Convert.ToInt32(a);
            //int y = Convert.ToInt32(b);
        }
    }
}