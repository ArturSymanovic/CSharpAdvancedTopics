using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharp
{

    // where T : IComparable - interface
    // where T : Product - class or child
    // where T : struct - value type
    // where T : class - reference type
    // where T : new() - object with default constructor

    class Utilities<T> where T: IComparable, new()
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }
        
        public T Max(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }

        public void DoSomething(T value)
        {
            var obj = new T();
        }
    }

    class Utilities1
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        public T Max<T>(T a, T b) where T : IComparable
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
}
