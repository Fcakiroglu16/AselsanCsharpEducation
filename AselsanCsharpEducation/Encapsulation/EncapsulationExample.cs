using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AselsanCsharpEducation.Encapsulation
{
    public class PersonClient
    {
        public PersonClient()
        {
            var person = new Person();

            person.Id = 1;
            person.Name = "Ahmet";
            person.Age = 23;
            //person.SetName("Ahmet");
            var name = person.Name;
            //person.GetName();
        }
    }


    public class Person
    {
        public int Id { get; set; }

        private string _name;

        public string Name
        {
            get => _name;

            set
            {
                if (value.Length < 5)
                {
                    throw new Exception("Name değeri 5 karakterden küçük olamaz");
                }

                _name = value;
            }
        }

        public int Age { get; set; }

        //public void SetName(string name)
        //{
        //    if (name.Length < 5)
        //    {
        //        throw new Exception("Name değeri 5 karakterden küçük olamaz");
        //    }

        //    Name = name;
        //}

        //public string GetName()
        //{
        //    return Name;
        //}
    }
}