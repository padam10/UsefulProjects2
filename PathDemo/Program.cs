using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryForPathDemo;

namespace PathDemo
{
    using System.IO;

    class Program
    {
        static void Main(string[] args)
        {
            string path = Directory.GetCurrentDirectory();
            string totalPath = Path.Combine(path, "V2PublishFixtureMessage.Json");
            //You can also use path+ directory but this is better
            // Make sure to not include any \\ infront of the file name. 
            // It will give you an error. 
            PathClass p = new PathClass();
            p.ReadAFile(totalPath);
            Console.Read();

        }
    }
}
