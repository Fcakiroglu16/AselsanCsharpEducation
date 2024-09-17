using System;
using System.Collections.Generic;

namespace AselsanCsharpEducation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CollectionLesson collectionLesson = new CollectionLesson();


            collectionLesson.HashSetExample();
            //collectionLesson.AddCollection();


            //ArrayLessons arrayLessons = new ArrayLessons();

            //arrayLessons.AddNumbers();


            var loop = new Loop();

            //loop.ForLoop();
            //loop.WhileLoop();
            //loop.DoWhileLoop();
            //var ifElseSwitchCase = new IfElseSwitchCase();


            ////tuple
            //var result = ifElseSwitchCase.Calculate4("2", "3");

            //if (result.isSuccess)
            //{
            //    Console.WriteLine(result.data);
            //}
            //else
            //{
            //    Console.WriteLine(result.errorMessage);
            //}

            ////service result
            //var serviceResult = ifElseSwitchCase.Calculate5("2", "3");

            //if (serviceResult.IsSuccess)
            //{
            //    Console.WriteLine(result.data);
            //}
            //else
            //{
            //    Console.WriteLine(result.errorMessage);
            //}
        }
    }
}