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
            #region Property
            //Employee e1 = new Employee();
            //e1.Salary = 50000;
            //Employee.BaseSalary = e1.Salary;
            //Console.WriteLine(Employee.BaseSalary);
            //Employee employee = new Employee();
            //employee.Salary = 5000;
            //employee.Age = 30;
            //Console.WriteLine(employee.Salary); 
            #endregion
            #region Array
            ////int[] arr = new int[6] ;

            //Creature[] arr = new Creature[3]
            //{
            //    new Employee(),
            //    new Creature(),
            //    new Employee()
            //};

            //foreach (var item in arr)
            //{
            //    item.Move();
            //} 
            #endregion
            #region String
            //string str = "Hello"; // String is Imutable 'Onece Created Never Changed'

            //str += "ITI";
            //Test(str);
            //Console.WriteLine(str); 
            #endregion
            #region Operator Overloading

            //Sample s1 = new Sample() { Name = "Maher", Img = "1" };
            //Sample s2 = new Sample() { Name = "Saber", Img = "2" };

            //Sample s3 = s1+ s2;
            //Sample s4 = s1+ 5;

            //Sample s5 = 6;
            //string s = (string)s1;

            //Console.WriteLine(s);

            #endregion
            #region Genarics
            //MyList<int> list = new MyList<int>();
            //list.Add(4);
            //var x = list.GetObjects();
            //Console.WriteLine(list.GetByIndex(0));
            //foreach (var item in list.GetObjects())
            //{
            //    Console.WriteLine(item);
            //}

            //MyList<Employee> list = new MyList<Employee>();

            //list.Add(new Employee() { Name = "saber" ,Salary = 1000 , Id = 010});

            //Console.WriteLine(list.GetByIndex(0).Salary);
            //Console.WriteLine(list.GetByIndex(10)); 
            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            //Console.WriteLine(LastElement(arr));
            #endregion
            #region Interface
            //Human human = new Human();
            //human.Speed = 100;
            //Car car = new Car();
            //car.Speed = 200;
            //MoveObject(car);

            //Human[] humans = new Human[3]
            //{
            //    new Human {Id = 2, Name = "Saber" , Speed = 200 },
            //    new Human {Id = 3, Name = "Ahmed" , Speed = 250 },
            //    new Human {Id = 1, Name = "Maher" , Speed = 300},
            //};

            //Array.Sort(humans);

            //for (int i = 0; i < humans.Length; i++)
            //{
            //    Console.WriteLine(humans[i]);
            //}

            #endregion
            #region IEnumrable & IEnumerator

            //MyListt myListt = new MyListt();

            //myListt.Add(10);
            //myListt.Add(30);
            //myListt.Add(40);
            //myListt.Add(30);

            //IEnumerator itra = myListt.GetEnumerator();

            //foreach (var item in myListt)
            //{
            //    Console.WriteLine((int)item);
            //}


            #endregion
            #region Dictionary // bulid using hashTable

            //Dictionary<int,Human> dic = new Dictionary<int , Human>();
            //dic.Add(1, new Human { Id = 1  , Name = "maher" ,Speed = 300});
            //dic.Add(2, new Human { Id = 2  , Name = "saber" ,Speed = 250 });

            //foreach (KeyValuePair<int , Human> item in dic) // KeyValuePair is Struct
            //{
            //    Console.WriteLine($"Key : {item.Key} , Human :{item.Value} " );
            //}

            #endregion

        }
        static void MoveObject(IMovable obj)
        {
            obj.Move();
        }
        static T LastElement<T>(T[] arr)
        {
            return arr[arr.Length - 1];
        }
        static void Test(string str)
        {
            str += " Saber"; 
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
