using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AselsanCsharpEducation.Abstractions
{
    internal class ServiceResult<T>
    {
        public T Data { get; set; }

        public List<string> Errors;

        public static ServiceResult<T> Success(T data)
        {
            return new ServiceResult<T>()
            {
                Data = data
            };
        }

        public static ServiceResult<T> Fail(List<string> errors)
        {
            return new ServiceResult<T>()
            {
                Errors = errors
            };
        }

        public static ServiceResult<T> Fail(string error)
        {
            return new ServiceResult<T>()
            {
                Errors = new List<string>() { error }
            };
        }
    }
}