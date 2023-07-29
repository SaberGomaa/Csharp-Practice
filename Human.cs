using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    internal class Human : IMovable , IComparable<Human>//IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Speed { get; set; }

        public override string ToString()
        {
            return $"ID : {Id} , Name : {Name} , Speed : {Speed}";
        }

        public void Move()
        {
            Console.WriteLine($"Human has Speed {Speed}");
        }

        public int CompareTo(Human? human)
        {
            if (Speed == human.Speed)
                return 0;
            else if (Speed > human.Speed)
                return 1;
            return -1;
        }

        //public int CompareTo(object? obj)
        //{
        //    if(obj is Human human)
        //    {
        //        if (Speed == human.Speed)
        //            return 0;
        //        else if(Speed > human.Speed) 
        //            return 1;
        //        return -1;
        //    }
        //    return 0;
        //}
    }
}
