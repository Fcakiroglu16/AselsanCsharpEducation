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
            #region action

            //Action
            //Action<int, int> action = new Action<int, int>(ActionMethod);
            Action<int, int> action = (a, b) => { Console.WriteLine(a + b); };

            action(2, 3);
            action.Invoke(2, 3);

            #endregion

            #region predicate

            //Predicate
            Predicate<int> predicate = (a) => a > 5;

            predicate(2);
            predicate(10);

            #endregion

            #region func

            //function

            Func<int, int, string> func = (x, y) => (x + y).ToString();
            Func<DateTime, int, DateTime> dateFunc = (date, number) => date.AddDays(number);

            //Func<int, int, string> func = (x, y) =>
            //{
            //    return (x + y).ToString();
            //};

            #endregion
        }

        public void ActionMethod(int a, int b)
        {
            Console.WriteLine($"{a} {b}");
        }
    }
}