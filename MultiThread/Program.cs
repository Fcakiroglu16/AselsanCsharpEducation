using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThread
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Write2(new List<string>() { "mesaj 1", "mesaj 2", "mesaj 3", "mesaj 4", "mesaj 5" });


            var x = Console.ReadLine();
            //var thread = new Thread(() => { Console.WriteLine("Merhaba Dünya 1"); });
            //var thread2 = new Thread(() => { Console.WriteLine("Merhaba Dünya 2"); });
            //thread.Start();
            //thread2.Start();
        }


        static void Write(List<string> messages)
        {
            foreach (var message in messages)
            {
                var thread = new Thread(() => { Console.WriteLine(message); });
                thread.Start();
            }
        }

        static void Write2(List<string> messages)
        {
            foreach (var message in messages)
            {
                Task.Run(() => { Console.WriteLine(message); });
            }
        }

        static void Write3(List<string> messages)
        {
            Parallel.ForEach(messages, message => { Console.WriteLine(message); });
        }

        public async Task WriteAsync(List<string> messages)
        {
            foreach (var message in messages)
            {
                Console.WriteLine(message);
            }
        }
    }
}