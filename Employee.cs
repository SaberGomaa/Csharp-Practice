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
        public static double BaseSalary = 2500;

        private int salary;

        public int Age { private get; set; }
        public int Salary
        {
            get
            {
                return salary;
            }
            set
            {
                if (value > 3000)
                    salary = value;
                else
                    salary = (int)BaseSalary;
            }
        }
        public Employee() : base() 
        {
            Id = 0;
            Name = "";
            base.Weight = 1;
        }

        public Employee(int id) : this(id, string.Empty ,22)
        {
        }

        public Employee(int id , string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
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

            //Employee e;

            //if (obj is Employee)
            //{
            //    e = (Employee)obj;
            //    return this.Id == e.Id;
            //}
            //else return false;


            if (obj is Employee e)
            {
                return this.Id == e.Id;
            }
            else return false;

        }
        public override void Move()
        {
            Console.WriteLine("Employee is move .. ");
        }

        //Shallow copy is a bit-wise copy of an object.
        //Deep copy stores copies of the object's value
        public Employee Clone()
        {
            Object obj = base.MemberwiseClone(); // Shallow copy // To take Copy from Obj and assign to other refernce
            
            return obj as Employee;
        }

    }
}
