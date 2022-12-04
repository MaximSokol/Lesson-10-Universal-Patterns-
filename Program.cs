using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson_10__Universal_Patterns_.Additional_Task;
using Lesson_10__Universal_Patterns_.Task_2;
using Lesson_10__Universal_Patterns_.Task_3;
using Lesson_10__Universal_Patterns_.Task_4;

namespace Lesson_10__Universal_Patterns_
{
   static class Program
    {
        public static T[] GetArray<T>(this MyList<T> arr)
        {
            T[] newArr = new T[arr.Count];
            for (int i = 0; i < arr.Count; i++)
            {
                newArr[i] = arr[i];
            }
            return newArr;
        }
        //-------------------------------------------------------------------

        static void Main(string[] args)
        {
            // Addional Task

            //Console.WriteLine(GenericClass<int>.FactoryMethod().ToString());

            // Task 2 

            //var ls = new MyList<int>();
            //ls.Add(10);
            //Console.WriteLine(ls[0]);
            //Console.WriteLine(ls.Count);

            //Console.WriteLine(ls.Clear());
            //Console.WriteLine(ls[0]);

            // Task 3

            //var myDictiobary = new MyDictionary<int, int>();
            //myDictiobary.Add(0, 100);
            //Console.WriteLine(myDictiobary.CountElems);
            //Console.WriteLine(myDictiobary[0]);
            //myDictiobary.ClearList();

            // Task 4

            var mylst = new MyListObjects();

            mylst.Add("Add");
            mylst.Add(117.8);
            mylst.Add(56);

            Console.WriteLine(mylst.ToString());
        }
    }

}
