using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AsyncExample
{
    internal class FileHelper
    {
        public void Write(string message)
        {
            System.IO.File.WriteAllText("example.txt", message);
        }

        public async Task WriteAsync(string message)
        {
            var streamWriter = new StreamWriter("example.async.txt", true);

            await streamWriter.WriteLineAsync(message);
            streamWriter.Close();
            streamWriter.Dispose();
        }


        public async Task WriteAsync(List<string> messages)
        {
            var streamWriter = new StreamWriter("example.async-1.txt", true);
            var streamWriter2 = new StreamWriter("example.async-2.txt", true);
            var streamWriter3 = new StreamWriter("example.async-3.txt", true);


            var task1 = streamWriter.WriteLineAsync(messages[0]);
            var task2 = streamWriter2.WriteLineAsync(messages[1]);
            var task3 = streamWriter3.WriteLineAsync(messages[2]);


            await Task.WhenAll(task1, task2, task3);


            streamWriter.Close();
            streamWriter.Dispose();
            streamWriter2.Close();
            streamWriter2.Dispose();
            streamWriter3.Close();
            streamWriter3.Dispose();
        }


        public Task<HttpResponseMessage> MakeToRequest()

        {
            var httpClient = new HttpClient();

            return httpClient.GetAsync("https://www.googledsfdsfdsf.com");
        }
    }
}