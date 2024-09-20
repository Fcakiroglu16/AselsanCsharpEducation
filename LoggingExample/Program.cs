using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;
using Serilog.Configuration;
using Serilog.Core;
using Serilog.Events;

namespace LoggingExample
{
    internal class Program
    {
        //using var log = new LoggerConfiguration()
        //    .WriteTo.Console()
        //    .WriteTo.File("log.txt")
        //    .CreateLogger();


        internal static Logger logger = new LoggerConfiguration()
            .MinimumLevel.Information()
            .WriteTo.Console()
            .WriteTo.File("log.txt")
            .CreateLogger();

        static void Main(string[] args)
        {
            logger.Information("bilgilendirme logu");

            var i = "abc";
            try
            {
                var number = int.Parse(i);
            }
            catch (Exception e)
            {
                logger.Error(e, "");
                Console.WriteLine(e.Message);
            }
        }
    }
}