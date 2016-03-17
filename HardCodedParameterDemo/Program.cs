using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardCodedParameterDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person(2,"Padam",7);
            Console.WriteLine("Id is {0}, Name is {1} and Age is {2}",p.Id,p.Name,p.Age);
        
            // if you provide a value in a parameter it will take that value otherwise it will take the hard coded value
            //You can instantiate with just two parameters

            Person p2 = new Person(2, "Padam");
            Console.WriteLine("Id is {0}, Name is {1} and Age is {2}", p2.Id, p2.Name, p2.Age);

            //if there is a hard coded value in the parameter you can call the method with or without the that particular
            //parameter. If you provide it is going to be overided. 
           int twoParam =  p2.getTotal(1, 2);
            int threeParam = p2.getTotal(1, 2, 3);

            Console.WriteLine("With two Param is: {0} and with three param is:{1}",twoParam,threeParam);

            Console.Read();
        }
    }
}
