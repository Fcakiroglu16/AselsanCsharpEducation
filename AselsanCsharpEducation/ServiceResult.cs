using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AselsanCsharpEducation
{
    internal class ServiceResult
    {
        public string Error { get; set; } // instance property
        public int Data { get; set; }
        public bool IsSuccess { get; set; }


        public static ServiceResult Success(int data)
        {
            return new ServiceResult()
            {
                IsSuccess = true,
                Data = data
            };
        }

        public static ServiceResult Failure(string errorMessage)
        {
            return new ServiceResult()
            {
                IsSuccess = false,
                Error = errorMessage
            };
        }
    }
}