using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace MultiThread
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class PersonClient
    {
        // create person list with 20 item
        public List<Person> GetPersonList()
        {
            var personList = new List<Person>();
            for (int i = 0; i < 20; i++)
            {
                personList.Add(new Person()
                {
                    FirstName = $"First Name {i}",
                    LastName = $"Last Name {i}"
                });
            }

            return personList;
        }

        public void Method()
        {
            foreach (var person in GetPersonList())
            {
                var fullName = $"{person.FirstName} {person.LastName}";
            }

            Parallel.ForEach(GetPersonList(), person =>
            {
                var fullName = $"{person.FirstName} {person.LastName}";
            });
        }
    }
}