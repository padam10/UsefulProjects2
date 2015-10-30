using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstDemo
{
    using System.ComponentModel.DataAnnotations;

    public class Department
    {
        [Key]
        int Id { get; set; }
        public ICollection<Employee> Employees { get; set; }

        public Employee Employee { get; set; }
    }
}
