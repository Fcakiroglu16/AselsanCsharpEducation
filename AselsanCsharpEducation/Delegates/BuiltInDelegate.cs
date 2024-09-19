using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AselsanCsharpEducation.Delegates
{
    internal delegate void Action(int a, int b);

    internal class BuiltInDelegate
    {
        void Example()
        {
            Action<int, int> action = new Action<int, int>(ActionMethod);

            action.Invoke(2, 5);
            action(2, 5);
            // Action    void ( parameters)
            //Predicate
            // Function
        }

        public void ActionMethod(int a, int b)
        {
            Console.WriteLine($"{a} {b}");
        }

        public void Calculate(int a, int b, Action<int, int> action)
        {
            action.Invoke(a, b);
        }
    }
}