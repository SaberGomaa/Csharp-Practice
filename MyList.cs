using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    internal class MyList<T> where T : class
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
            return arr[index];
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
