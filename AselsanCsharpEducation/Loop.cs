using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AselsanCsharpEducation
{
    internal class Loop
    {
        public void ForLoop()
        {
            //break;

            for (int i = 0; i <= 10; i++)
            {
                if (i == 5)
                {
                    continue;
                }

                Console.WriteLine($"for loop :{i} ");
            }
        }

        public void WhileLoop()
        {
            var i = 0;
            while (i < 20)
            {
                //i = i + 1;

                Console.WriteLine($"While loop : {i++}");
            }
        }

        public void DoWhileLoop()
        {
            var i = 0;


            do
            {
                if (i == 10) continue;

                Console.WriteLine($"While loop : {i++}");
            } while (i < 20);
        }

        public void ForeachLoop()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };


            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}