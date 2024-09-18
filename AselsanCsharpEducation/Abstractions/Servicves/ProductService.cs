using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AselsanCsharpEducation.Abstractions
{
    internal class ProductService
    {
        private readonly ProductRepository _productRepository = new ProductRepository();


        public ServiceResult<List<Product>> GetAll()
        {
            var productListWithTax = new List<Product>();

            var products = _productRepository.GetAll();


            foreach (var product in products)
            {
                var productWithTax = new Product(product.Id, product.Name, product.Price * 1.20m);
                productListWithTax.Add(productWithTax);
            }


            return new ServiceResult<List<Product>>()
            {
                Data = productListWithTax
            };
        }


        public ServiceResult<Product> GetById(int id)
        {
            var hasProduct = _productRepository.GetById(id);

            if (hasProduct is null)
            {
                //return null;
                //throw new Exception("");

                return new ServiceResult<Product>()
                {
                    Errors = new List<string>() { "Ürün bulunamadı" }
                };
            }

            var newProduct = new Product(hasProduct.Id, hasProduct.Name, hasProduct.Price *= 1.2m);

            return new ServiceResult<Product>()
            {
                Data = newProduct
            };
        }
    }
}