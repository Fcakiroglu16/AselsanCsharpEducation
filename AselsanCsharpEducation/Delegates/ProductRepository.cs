using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AselsanCsharpEducation.Delegates
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    internal class ProductRepository
    {
        private List<Product> products = new List<Product>();


        public ProductRepository()
        {
            products.Add(new Product { Id = 1, Name = "Laptop", Price = 1000 });
            products.Add(new Product { Id = 2, Name = "Mouse", Price = 20 });
            products.Add(new Product { Id = 3, Name = "Keyboard", Price = 50 });
            products.Add(new Product { Id = 4, Name = "Monitor", Price = 200 });
        }


        //public Product GetById(int id)
        //{
        //    return products.FirstOrDefault(p => p.Id == id);
        //}

        //public Product GetByName(string name)
        //{
        //    return products.FirstOrDefault(p => p.Name == name);
        //}

        public List<Product> Where(Func<Product, bool> productWhere)
        {
            return products.Where(productWhere).ToList();
        }

        public Product FirstOrDefault(Func<Product, bool> productWhere)
        {
            return products.Where(productWhere).FirstOrDefault();
        }
    }
}