using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AselsanCsharpEducation.Abstractions.Example
{
    internal class A
    {
        internal void X()
        {
            IB b = new B();

            var result = b.Add(2, 3);
        }
    }
}