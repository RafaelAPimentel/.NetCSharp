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
            MyGenericMethods.Swap<int>(ref a, ref b);
            Console.WriteLine($"After swap: {a}:{b}");
            Console.WriteLine();

            //swap 2 strings
            string s1 = "Hello", s2 = "There";
            Console.WriteLine($"Before swap: {s1}:{s2}");
            MyGenericMethods.Swap<string>(ref s1,ref s2);
            Console.WriteLine($"After swap: {s1}:{s2}\n");
            MyGenericMethods.DisplayBaseClass<string>();
            MyGenericMethods.DisplayBaseClass<int>();
            MyGenericMethods.DisplayBaseClass<object>();
            
            Console.ReadKey();
        }


    }
}
