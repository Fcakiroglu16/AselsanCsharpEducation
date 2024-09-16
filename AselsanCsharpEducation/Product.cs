using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AselsanCsharpEducation
{
    internal class Product
    {
        internal int Id { get; set; }


        private string _name;

        internal string Name
        {
            get => _name;
            //get { return _name; }
            set
            {
                if (value.Length <= 6)
                {
                    throw new Exception("Name must be longer than 6 characters");
                }

                _name = value;
            }
        }

        //public void SetName(string name)
        //{
        //    Name = name;
        //}
        internal decimal Price { get; set; }

        //public Product()
        //{
        //}

        public Product(int id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
    }
}