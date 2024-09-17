using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AselsanCsharpEducation
{
    internal class IfElseSwitchCase
    {
        public ServiceResult Calculate5(string a, string b)
        {
            // fast fail
            //Guard Clauses
            if (!int.TryParse(a, out int asAsNumber))
            {
                return ServiceResult.Failure("a değeri sayısal bir değer değildir");
                //return new ServiceResult()
                //{
                //    IsSuccess = false,
                //    Error = "a değeri sayısal bir değer değildir"
                //};
            }

            if (!int.TryParse(b, out int bAsNumber))
            {
                return ServiceResult.Failure("b değeri sayısal bir değer değildir");
                //return new ServiceResult()
                //{
                //    IsSuccess = false,
                //    Error = "b değeri sayısal bir değer değildir"
                //};
            }

            if (asAsNumber > 10 && bAsNumber > 10)
            {
                return ServiceResult.Success(asAsNumber + bAsNumber + 10);
                //return new ServiceResult()
                //{
                //    IsSuccess = true,
                //    Data = asAsNumber + bAsNumber + 10
                //};
            }

            return ServiceResult.Success(asAsNumber + bAsNumber);
            //return new ServiceResult()
            //{
            //    IsSuccess = true,
            //    Data = asAsNumber + bAsNumber
            //};
        }

        public (bool isSuccess, int data, string errorMessage) Calculate4(string a, string b)
        {
            // fast fail
            //Guard Clauses
            if (!int.TryParse(a, out int asAsNumber))
            {
                return (false, 0, "a değeri sayısal bir değer değildir");
            }

            if (!int.TryParse(b, out int bAsNumber))
            {
                return (false, 0, "b değeri sayısal bir değer değildir");
            }

            if (asAsNumber > 10 && bAsNumber > 10)
            {
                return (true, asAsNumber + bAsNumber + 10, "");
            }

            return (true, asAsNumber + bAsNumber, "");
        }

        public int Calculate(string a, string b)
        {
            // fast fail
            //Guard Clauses
            if (!int.TryParse(a, out int asAsNumber))
            {
                throw new Exception("a değeri sayısal bir değer değildir");
                //Console.WriteLine("a değeri sayısal bir değer değildir");
                //return 0;
            }

            if (!int.TryParse(b, out int bAsNumber))
            {
                throw new Exception("b değeri sayısal bir değer değildir");
                //Console.WriteLine("b değeri sayısal bir değer değildir");
            }

            if (asAsNumber > 10 && bAsNumber > 10)
            {
                return asAsNumber + bAsNumber + 10;
            }

            return asAsNumber + bAsNumber;
        }

        public void Calculate(int a, int b)
        {
            if (a == b)
            {
                Console.Write("a==b");
                return;
            }

            if (a > b)
            {
                Console.Write("a>b");
                return;
            }

            if (b > a)
            {
                Console.Write("b>a");
            }
        }


        public string IfElseGood(int a)
        {
            if (a < 10)
            {
                return "a is less than 10";
            }

            if (a < 50)
            {
                return "a is less than 50";
            }

            if (a < 100)
            {
                return "a is less than 100";
            }

            return "a is greater than 100";


            //if (a < 10)
            //{
            //    return "a is less than 10";
            //}
            //else if (a < 50)
            //{
            //    return "a is less than 50";
            //}
            //else if (a < 100)
            //{
            //    return "a is less than 100";
            //}
            //else
            //{
            //    return "a is greater than 100";
            //}
        }


        public void IfElseBad(int a)
        {
            if (a < 10)
            {
            }
            else if (a < 50)
            {
            }

            else if (a < 100)
            {
            }
            else
            {
            }
        }

        public string IfElse(int a, int b)
        {
            return a > b ? "a is greater than b" : "b is greater than a";


            if (a > b)
                Console.WriteLine("a is greater than b");
            else
                Console.WriteLine("b is greater than a");
            if (a > b)
            {
                Console.WriteLine("a is greater than b");
            }
            else
            {
                Console.WriteLine("b is greater than a");
            }
        }
    }
}