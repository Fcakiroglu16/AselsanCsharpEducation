using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AselsanCsharpEducation.Abstractions
{
    internal class StockRepository : IGenericRepository<Stock>
    {
        public List<Stock> GetAll()
        {
            throw new NotImplementedException();
        }

        public Stock GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Add(Stock product)
        {
            throw new NotImplementedException();
        }

        public void Update(Stock product)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Stock> GetPaged(int pageNumber, int pageSize)
        {
            throw new NotImplementedException();
        }
    }
}