using System;

namespace AselsanCsharpEducation.Inheritance
{
    public class Client
    {
        public void X()
        {
            var editor = new Editor(2, "ahmet");

            //var person = new Person();

            //var manager = new Manager();
            ////manager.GetFullName();
        }
    }

    public class Person
    {
        public Person(int Id, string name)
        {
            Id = Id;
            Name = name;
        }

        public Person(int age)
        {
            Age = age;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        private int X { get; set; }

        protected string GetFullName()
        {
            return $"{Name} {Age}";
        }
    }


    public class Editor : Person
    {
        public Editor(int Id, string name) : base(Id, name)
        {
        }

        public Editor(int age, int salary) : base(age)
        {
            Salary = salary;
        }


        public decimal Salary { get; set; }
    }

    public class Manager : Editor
    {
        public Manager(int Id, string name) : base(Id, name)
        {
        }

        public void Method(Person p)
        {
        }
    }
}