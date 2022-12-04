using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10__Universal_Patterns_.Additional_Task
{
    class GenericClass<T>
    {
       public static GenericClass<T> FactoryMethod()
       {
            return new GenericClass<T>();
       }
    //-------------------------------------------------------
    }
}
