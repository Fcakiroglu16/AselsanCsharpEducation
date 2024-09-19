using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AselsanCsharpEducation.Polymorphism
{
    public class Animal
    {
        public virtual void Sound()
        {
            Console.WriteLine("Sound");
        }
    }


    public class Cat : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Cat > Sound");
            base.Sound();
        }
    }
}