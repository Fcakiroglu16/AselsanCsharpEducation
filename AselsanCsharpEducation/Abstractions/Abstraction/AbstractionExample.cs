using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AselsanCsharpEducation.Abstractions.Abstraction
{
    public class Product
    {
    }

    public abstract class ProductRepository
    {
        public abstract List<Product> GetAll();
        public abstract Product GetById(int id);
    }


    public class Client
    {
        void X()
        {
            var manager = new Manager();
        }
    }

    public abstract class Person
    {
        public abstract int X { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }

        public abstract void Call();

        public void SendEmail()
        {
            Console.WriteLine("Email sent");
        }
    }

    public class Manager : Person
    {
        public Manager()
        {
            Id = 10;
        }


        public override int X { get; set; }

        public override void Call()
        {
            throw new NotImplementedException();
        }
    }

    public class Employee : Person
    {
        public string Department { get; set; }

        public override int X { get; set; }

        public override void Call()
        {
            throw new NotImplementedException();
        }
    }


    public class Developer : Person
    {
        public override int X { get; set; }

        public override void Call()
        {
            throw new NotImplementedException();
        }
    }
}