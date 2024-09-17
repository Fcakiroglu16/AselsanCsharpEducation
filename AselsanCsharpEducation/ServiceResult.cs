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
    }
}