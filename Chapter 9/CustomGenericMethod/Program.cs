using System;

namespace CustomGenericMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****Fun with Generic Method****");
            int a = 10, b = 90;
            Console.WriteLine("Before Swap {0}, {1}", a, b);
            MyGenericClass.Swap<int>(ref a, ref b);
            Console.WriteLine("After Swap {0}, {1}", a, b);
            Console.WriteLine();

            //swap 2 strings
            string s1 = "Hello", s2 = "World";
            Console.WriteLine("Before Swap {0}, {1}", a, b);
            MyGenericClass.Swap<string>(ref s1, ref s2);
            Console.WriteLine("After Swap {0}, {1}", a, b);
            Console.WriteLine();

            MyGenericClass.DisplayBaseClass<string>();
            Console.Read();
        }

    }
    public static class MyGenericClass
    {
        public static void Swap<T>(ref T a, ref T b)
        {
            Console.WriteLine("You sent the Swap method a {0}", typeof(T));

            T temp = a;
            a = b;
            b = temp;

        }

        public static void DisplayBaseClass<T>() {
            Console.WriteLine("Base class of {0} is {1}",typeof(T),typeof(T).BaseType );
        }
    }
}
