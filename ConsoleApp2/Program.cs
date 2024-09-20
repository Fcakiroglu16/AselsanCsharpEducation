using Shared.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SharedLogging.Logger.Information("Main methodu çalıştı");

            var product = new Product();
        }
    }
}