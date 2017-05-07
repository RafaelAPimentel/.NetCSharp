using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomGenericMethods
{
    class MyGenericMethods
    {
        public static void Swap<T>(ref T a, ref T b)
        {
            Console.WriteLine($"You sent the Swap() method a {typeof(T)}");
            T temp;
            temp = a;
            a = b;
            b = temp;
        }

        public static void DisplayBaseClass<T>()
        {
            //BaseType is  am ethod used in reflection
            Console.WriteLine($"Base class of {typeof(T)} is: {typeof(T).BaseType }");
        }
    }
}
