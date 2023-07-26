using System.Collections;

namespace Practise
{
   

    internal class Program
    {

        static void Main(string[] args)
        {
            #region Enums
            // Bitwise OR
            //Color color = Color.Red | Color.Green;
            //Console.WriteLine(color);

            #endregion
            #region Struct
            //Complex c = new Complex(10);

            //Console.WriteLine(MyFun(c));

            //Console.WriteLine(c.Name);

            //Complex c1 = new Complex(id: 10, name: "saber");
            //Complex c2 = new Complex(10);

            //c = c1;
            //Console.WriteLine(c.Name); 
            #endregion
            #region OOP

            //Employee e1 = new Employee(10, "Saber");

            //Employee e2 = new Employee(20, "Maher");//Unreachable Object After Assignment 

            //e2=e1; // Two Refrences ( Stack ) Go To Same Object ( Heap )

            //Console.WriteLine(e2.Name);
            //e2.Name = "Ahmed";
            //Console.WriteLine(e1.Name);

            //Employee e = new Employee(10 , "saber") { Id = 20, Name = "Saber", Salary = 2000 }; // Object Intializer

            //Console.WriteLine(e.Name);


            //Employee e = new Employee() { Id = 20, Name = "saber", Salary = 2000 };

            //Employee e1 =  e.Clone();

            //Console.WriteLine(e1);
            #endregion

            Employee e1 = new Employee();

            e1.Salary = 50000;

            Employee.BaseSalary = e1.Salary;

            Console.WriteLine(Employee.BaseSalary);

        }
        public static int MyFun(Complex c)
        {
            c.Id = 15;
            return c.Id +10 ;
        }
        public static List<int> oddNumbers(int l, int r)
        {
            List<int> ll = new List<int>();

            for (int i = l; i <= r; i++)
            {
                if (i % 2 != 0)
                {
                    ll.Add(i);
                }
            }
            return ll;
        }
    }
}
