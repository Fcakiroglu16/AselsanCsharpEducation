using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AselsanCsharpEducation.Abstractions.Example2
{
    internal interface IFile
    {
        void Write(string text);
    }

    internal interface IIFile
    {
        void Write(int text);
    }

    public class FileA : IFile, IIFile
    {
        public void Write(string text)
        {
            Console.WriteLine("A");
        }


        public void Write(int text)
        {
            throw new NotImplementedException();
        }
    }
}