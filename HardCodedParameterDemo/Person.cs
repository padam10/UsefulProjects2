using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardCodedParameterDemo
{
    public class Person
    {
        public Person(int id, string name, int age = 5)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public int getTotal(int a, int b, int c = 10)
        {
            return a + b + c;
        }
    }
}
