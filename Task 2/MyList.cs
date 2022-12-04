using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10__Universal_Patterns_.Task_2
{
    class MyList<T> : IMyList<T>
    {
        T[] arr = null;
        //--------------------------------------------------------------------------

        public MyList()
        {
            this.arr = new T[0];
        }
        //--------------------------------------------------------------------------

        public void Add(T elem)
        {
            T[] expandedArray = new T[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                expandedArray[i] = arr[arr.Length];
            }
            expandedArray[arr.Length] = elem;
            arr = expandedArray;
        }
        //--------------------------------------------------------------------------

        public T this[int index]
        {
            get
            {
              return arr[index];
            }
        }
        //--------------------------------------------------------------------------

        public int Count => this.arr.Length;
        //--------------------------------------------------------------------------

        public bool Clear()
        {
            if (arr.Length > 0)
            {
                arr = null;
                return true;
            }
            else
                return false; 
        }
        //--------------------------------------------------------------------------
    }
}
