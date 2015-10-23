using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

// Files get locked by FileStream until the stream is closed. 
//FileShare enumeration can change this behavior. 


namespace FileAndStreamDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // check the following clas to demo for the filemode and  file access
            FileModeAndFileAccess fmfa = new FileModeAndFileAccess();
            fmfa.FileModeFileAccessExample();



            Console.WriteLine("Done");
            Console.Read();
        }
    }
}
