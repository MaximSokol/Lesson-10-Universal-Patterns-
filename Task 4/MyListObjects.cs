using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10__Universal_Patterns_.Task_4
{
    class MyListObjects
    {
        object [] arr = null;
        //--------------------------------------------------------------------------

        public MyListObjects()
        {
            this.arr = new object[0];
        }
        //--------------------------------------------------------------------------

        public void Add(object a)
        {
            object[] tempArray = new object[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                tempArray[i] = arr[i];
            }
            tempArray[arr.Length] = a;
            arr = tempArray;
        }
        //--------------------------------------------------------------------------

        public object this[int index]
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

        public override string ToString()
        {
            string str = null;
            for (int i = 0; i < arr.Length; i++)
            {
                str += arr[i] + " ";
            }
            return $"{str}";
        }
        //--------------------------------------------------------------------------
    }
}
