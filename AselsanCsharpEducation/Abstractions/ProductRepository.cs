using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AselsanCsharpEducation.Abstractions
{
    internal class ProductRepository : IProductRepository
    {
        private static List<Product> _productList = new List<Product>(); // static member

        static ProductRepository()
        {
            _productList.Add(new Product(1, "kalem 1", 100));
            _productList.Add(new Product(2, "kalem 2", 100));
            _productList.Add(new Product(3, "kalem 3", 100));
        }

        public List<Product> GetAll()
        {
            return _productList;
        }

        public Product GetById(int id)
        {
            return _productList.SingleOrDefault(x => x.Id == id);
        }

        public void Add(Product product)
        {
            _productList.Add(product);
        }

        public void Update(Product product)
        {
            var productToUpdate = GetById(product.Id);
            productToUpdate.Name = product.Name;
            productToUpdate.Price = product.Price;
        }

        public void Delete(int id)
        {
            _productList.Remove(GetById(id));
        }

        public List<Product> GetPaged(int pageNumber, int pageSize)
        {
            throw new NotImplementedException();
        }
    }
}