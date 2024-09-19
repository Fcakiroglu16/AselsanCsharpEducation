using System;
using System.Collections.Generic;
using AselsanCsharpEducation.Delegates;

namespace AselsanCsharpEducation
{
    internal class Program
    {
        static bool IsProduct(Product p)
        {
            return p.Price > 500;
        }

        static bool IsProduct2(Product p)
        {
            return p.Id == 2;
        }

        static void Main(string[] args)
        {
            var productRepository = new ProductRepository();

            productRepository.Where(IsProduct);
            productRepository.FirstOrDefault(IsProduct2);
            productRepository.FirstOrDefault(p => p.Id == 2);


            var calculate = new Calculate();

            //var salary = calculate.CalculateSalary(1000, 200, 2, SalaryType.Employee);

            var buttonIndex = 2;

            Dictionary<int, CalculateSalaryDelegate> calculateSalaryDelegateDictionary =
                new Dictionary<int, CalculateSalaryDelegate>
                {
                    { 0, calculate.ManagerCalculate },
                    { 1, calculate.EditorCalculate },
                    { 2, calculate.EmployeeCalculate }
                };


            Console.WriteLine(calculateSalaryDelegateDictionary[buttonIndex](1000, 10, 2));


            var salary2 = calculate.CalculateSalaryGood(1000, 200, 2, calculate.ManagerCalculate);
            var salary3 = calculate.CalculateSalaryGood(1000, 200, 2, CustomCalculate);

            //Console.WriteLine($"Maaş:{salary}");


            //var delegateExample = new DelegateExample();

            //delegateExample.Work();

            //string name = "asp.net core";


            //Console.WriteLine(name.GetFirstCharacter());


            //var car = new Car();

            //car.GetEngineAndGearBox();

            //var cat = new Cat();
            //cat.Sound();


            //List<Animal> animalList =
            //[
            //    new Dog(),
            //    new Cat(),
            //    new Bird()
            //];

            //foreach (var animal in animalList)
            //{
            //    animal.Sound();

            //    if (animal is IRun animalAsRun)
            //    {
            //        animalAsRun.Run();
            //    }
            //}
        }

        static decimal CustomCalculate(decimal baseSalary, decimal bonus, int childCount)
        {
            return baseSalary * bonus * childCount * 20;
        }
    }
}