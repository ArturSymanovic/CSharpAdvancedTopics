using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            object obj = "Artur";

            obj.GetHashCode();
            //obj.GetHashCode(); With Reflection 
            var methodInfo = obj.GetType().GetMethod("GetHashCode");
            methodInfo.Invoke(obj, null);

            //Not compiling
            //object excelObject = "Artur";
            //excelObject.Optimize();
            //compiling (exception because in reality there are no Optimize method)
            dynamic excelObject = "Artur";
            excelObject.Optimize();

            //Woud run without exceptions
            dynamic name = "Artur";
            name = 10;

            dynamic a = 10;
            dynamic b = 5;
            var c = a + b;


            int i = 5;
            dynamic d = i;

        }
    }
}
