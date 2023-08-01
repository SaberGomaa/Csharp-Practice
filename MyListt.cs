using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    internal class MyListt : IEnumerable
    {
        int[] arr;
        int lastIndex;
        public MyListt()
        {
            arr = new int[10];
            lastIndex = -1;
        }

        public void Add(int num)
        {
            if (lastIndex == arr.Length - 1)
            {
                Extend();
            }
            arr[++lastIndex] = num;
        }


        public int GetByIndex(int index)
        {
            if (lastIndex > 0 && lastIndex <= arr.Length - 1)
                return arr[index];
            else
                return new int();
        }

        public IEnumerator GetEnumerator()
        {
            return new Iterator(this);
        }

        public int[] GetObjects()
        {
            return arr;
        }

        private void Extend()
        {
        }

        class Iterator : IEnumerator
        {
            MyListt MyListt;
            int currentIndex = 0;
            public Iterator(MyListt myListt)
            {
                this.MyListt = myListt;
                currentIndex = -1;
            }

            public object Current => MyListt.arr[currentIndex];

            public bool MoveNext()
            {
                currentIndex++;
                return currentIndex <= MyListt.lastIndex;
            }

            public void Reset()
            {
                currentIndex = -1;
            }
        }
    }
}
