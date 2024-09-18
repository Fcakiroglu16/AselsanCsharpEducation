using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AselsanCsharpEducation.Abstractions
{
    internal interface IGenericRepository<T>
    {
        List<T> GetAll();

        T GetById(int Id);

        void Add(T product);

        void Update(T product);
        void Delete(int id);

        List<T> GetPaged(int pageNumber, int pageSize);
    }
}