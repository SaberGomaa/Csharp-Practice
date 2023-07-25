using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    public class Employee
    {
        public int Id;
        public string Name;
        public int Salary;

        public Employee() : this(1 , string.Empty)
        {
        }

        public Employee(int id) : this(id, string.Empty)
        {
        }

        public Employee(int id , string name)
        {
            Id = id;
            Name = name;
        }

    }
}
