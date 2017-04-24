using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomGenericMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with Custom Generic Methods****\n");

            //swap 2 ints
            int a = 10, b = 20;
            Console.WriteLine($"Before swap: {a}:{b}");
            Swap<int>(ref a, ref b);
            Console.WriteLine($"After swap: {a}:{b}");
            Console.WriteLine();

            //swap 2 strings
            string s1 = "Hello", s2 = "There";
            Console.WriteLine($"Before swap: {s1}:{s2}");
            Swap<string>(ref s1,ref s2);
            Console.WriteLine($"After swap: {s1}:{s2}");
            Console.ReadKey();
        }
        static void Swap<T>(ref T  a, ref T b) {
            Console.WriteLine($"You sent the Swap() method a {typeof(T)}");
            T temp;
            temp = a;
            a = b;
            b = temp;
        }

    }
}
