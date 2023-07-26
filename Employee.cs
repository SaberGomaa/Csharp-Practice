using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    public class Employee : Creature
    {
        public int Id;
        public string Name;
        public int Salary;

        public Employee() : base() 
        {
            Id = 0;
            Name = "";
            base.Weight = 1;
        }

        public Employee(int id) : this(id, string.Empty)
        {
        }

        public Employee(int id , string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"ID : {Id} , Name : {Name} , Salary : {Salary}";
        }

        public override bool Equals(object obj)
        {
            //Employee e = obj as Employee;
            //if (e == null) return false;
            //return this.Id == e.Id;
            
            Employee e;

            if (obj is Employee)
            {
                e = (Employee)obj;
                return this.Id == e.Id;
            }
            else return false;
        }
        public override void Move()
        {
            Console.WriteLine("Employee is move .. ");
        }

    }
}
