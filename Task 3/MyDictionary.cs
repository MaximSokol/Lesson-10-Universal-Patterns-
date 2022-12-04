using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson_10__Universal_Patterns_.Task_2;

namespace Lesson_10__Universal_Patterns_.Task_3
{
    class MyDictionary<TKey, TValue>
    {
        MyList<TKey> key = null;
        MyList<TValue> value = null;
        //--------------------------------------------

        public MyDictionary()
        {
            this.key = new MyList<TKey>();
            this.value = new MyList<TValue>();
        }
        //--------------------------------------------

        public void Add(TKey key, TValue value)
        {
            this.key.Add(key);
            this.value.Add(value);
        }
        //--------------------------------------------

        public string this[int index]
        {
            get
            {
                return $"Key:\t{key[index]}\nValue:\t{value[index]}\n";
            }
        }
        //--------------------------------------------

        public int CountElems
        {
            get { return this.key.Count; }
        }
        //--------------------------------------------

        public void ClearList()
        {
            Console.WriteLine(key.Clear());
        }
        //--------------------------------------------
    }
}
