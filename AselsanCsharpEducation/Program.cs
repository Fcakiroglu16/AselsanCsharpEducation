using System;
using System.Collections.Generic;

namespace AselsanCsharpEducation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ifElseSwitchCase = new IfElseSwitchCase();


            //tuple
            var result = ifElseSwitchCase.Calculate4("2", "3");

            if (result.isSuccess)
            {
                Console.WriteLine(result.data);
            }
            else
            {
                Console.WriteLine(result.errorMessage);
            }

            //service result
            var serviceResult = ifElseSwitchCase.Calculate5("2", "3");

            if (serviceResult.IsSuccess)
            {
                Console.WriteLine(result.data);
            }
            else
            {
                Console.WriteLine(result.errorMessage);
            }
        }
    }
}