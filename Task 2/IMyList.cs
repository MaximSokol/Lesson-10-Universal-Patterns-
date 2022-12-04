using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10__Universal_Patterns_.Task_2
{
    interface IMyList<T>
    {
        void Add(T elem);
        T this[int index] { get; }
        int Count { get; }
        bool Clear();
    }
}
