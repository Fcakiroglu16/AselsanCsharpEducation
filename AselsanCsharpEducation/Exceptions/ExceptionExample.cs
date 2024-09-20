using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AselsanCsharpEducation.Exceptions
{
    public class CalculateExceptionLesson
    {
        public int Add(string x, string y)

        {
            var numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };

            try
            {
                var xNumber = int.Parse(x);
                var yNumber = int.Parse(y);


                if (numbers.Contains(xNumber) && numbers.Contains(yNumber))
                {
                    return xNumber + yNumber;
                }

                throw new Exception("");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return 0;
        }
    }
}