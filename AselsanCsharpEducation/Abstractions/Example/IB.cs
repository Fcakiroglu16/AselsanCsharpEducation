using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AselsanCsharpEducation.Abstractions.Example
{
    internal interface IB
    {
        int Tax { get; set; }
        int Add(int a, int b);
        int Add5(int a, int b, int c);
    }
}