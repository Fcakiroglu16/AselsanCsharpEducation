using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AselsanCsharpEducation.Abstractions
{
    //contract
    internal interface IProductRepository
    {
        List<Product> GetAll();

        Product GetById(int Id);

        void Add(Product product);

        void Update(Product product);
        void Delete(int id);

        List<Product> GetPaged(int pageNumber, int pageSize);
    }
}