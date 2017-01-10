using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithArrays
{
    class Program
    {
        static void SimpleArrays()
        {
            //
            Console.WriteLine("=>Simple Arrays Creation");
            int[] myInts = new int[3];
            myInts[0] = 100;
            myInts[1] = 200;
            myInts[2] = 300;

            foreach (int i in myInts)
                Console.WriteLine(i);
            Console.WriteLine();
            
        }
        static void DeclareImplicitArrays()
        {
            Console.WriteLine("=> Declaring Implicit arrays");
            //Implicit Array of ints
            var a = new[] { 1, 4, 7, 23, 6, 1 };
            Console.WriteLine("a is a: {0}", a.ToString());

            //Implicit Array of double
            var b = new[] { 2.5, 6.5, 35.5, 75.5, 25.5, 75.5 };
            Console.WriteLine("b is a: {0}", b.ToString());

            //Implicit Array of string
            var c = new[] { "hello", null, "world" };
            Console.WriteLine("c is a: {0}", c.ToString());
            Console.WriteLine();
        }

        static void ArraysOfObjects()
        {
            Console.WriteLine("=> Array Of Objects");
            object[] myObject = new object[4];

            myObject[0] = 12;
            myObject[1] = false;
            myObject[2] = new DateTime(1969,3,24);
            myObject[3] = "Form & void";

            foreach (object obj in myObject)
            {
                Console.WriteLine("Type: {0}, value: {1}",obj.GetType(),obj);
            }
            Console.WriteLine();



        }
        static void Main(string[] args)
        {
            SimpleArrays();
            DeclareImplicitArrays();
            ArraysOfObjects();
            Console.ReadKey();
        }
    }
}
