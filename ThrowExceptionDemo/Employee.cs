using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThrowExceptionDemo
{
    public class Employee
    {
        public void CopyObject(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException("Parameter cannot be null", name);
            }

        }

    }
}
