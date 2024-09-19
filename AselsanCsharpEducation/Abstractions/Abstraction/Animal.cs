using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AselsanCsharpEducation.Abstractions.Abstraction

{
    public interface IRun
    {
        void Run();

        void Run(List<object> Parameters);
    }

    public abstract class Animal
    {
        public abstract void Sound();
    }


    public class Dog : Animal, IRun
    {
        public override void Sound()
        {
            Console.WriteLine("hav");
        }

        public void Run()
        {
            Console.WriteLine("dog > run");
        }

        public void Run(List<object> Parameters)
        {
            foreach (var parameter in Parameters)
            {
            }
        }
    }

    public class Cat : Animal, IRun
    {
        public override void Sound()
        {
            Console.WriteLine("Miyav");
        }

        public void Run()
        {
            Console.WriteLine("cat > run");
        }

        public void Run(List<object> Parameters)
        {
            throw new NotImplementedException();
        }
    }

    public class Bird : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Cik cik");
        }
    }
}