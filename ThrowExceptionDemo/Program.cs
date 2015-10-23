using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThrowExceptionDemo
{
    using System.Diagnostics;
    using System.IO;
    // Here you the Employee class is the throwing an exception and when you 
    // declare throw, you can handle it in the calling class like below here
    
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Padam";
            Employee emp = new Employee();
            try
            {
                emp.CopyObject(name);
            }
            catch (ArgumentNullException ex)
            {

                Console.WriteLine("Null arg" + ex.Message);
            }
            DateTimeOffset yesterday = DateTimeOffset.Parse("10/21/2015 03:00 -5");
            Console.WriteLine("Yesterday {0}",yesterday);

            DateTimeOffset dt = DateTimeOffset.Now;
            Console.WriteLine("This is from now{0}",dt);
            Debug.WriteLine(dt);
            Console.Read();

        }
    }
}
