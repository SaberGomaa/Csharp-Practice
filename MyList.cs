using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    internal class MyList<T> where T : new() //where T : class 
    {
        T[] arr;
        int CurrentIndex;
        public MyList()
        {
            arr = new T[10];
            CurrentIndex = -1;
        }

        public void Add(T num)
        {
            if(CurrentIndex == arr.Length-1)
            {
                Extend();
            }
            arr[++CurrentIndex] = num;
        }


        public T GetByIndex(int index)
        {
            if (CurrentIndex > 0 && CurrentIndex <= arr.Length - 1)
                return arr[index];
            else
                return new T();
        }

        public T[] GetObjects()
        {
            return arr;
        }

        private void Extend()
        {
        }
    }
}
