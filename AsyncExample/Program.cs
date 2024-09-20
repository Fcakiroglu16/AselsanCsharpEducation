using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncExample
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            FileHelper fileHelper = new FileHelper();

            await fileHelper.MakeToRequest();


            //fileHelper.Write("Mehaba Dünya");

            //    await fileHelper.WriteAsync("Mehaba Dünya");
            //}
        }
    }
}