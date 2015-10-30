using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseConstructorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            A classA = new A("Padam");
            B classB = new B(2);
            Console.Read();
        }
    }

    // This a base class
    public class A
    {
        public A(string a) // This is a base class
        {
            Console.WriteLine("From Constructor A");
        }
    }

    public class B : A
    {
        public B(int value):base("Hello")
        {
            Console.WriteLine("From Derived Constructor B");
        }
    }
}
