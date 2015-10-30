using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new EmployeeContext())
            {
                try
                {
                    Employee emp = new Employee() { FirstName = "Padam", LastName = "Bhandari" };
                    ctx.Employees.Add(emp);
                    ctx.SaveChanges();
                }
                catch (Exception e)
                {

                    Console.WriteLine("Exception is : " + e.Message);
                }
                Console.WriteLine("Saved");
                Console.Read();

            }
        }
    }
}
