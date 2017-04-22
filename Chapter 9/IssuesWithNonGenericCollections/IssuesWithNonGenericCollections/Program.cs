using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssuesWithNonGenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkWithArrayList();
            Console.ReadKey();
        }

        static void SimpleBoxUnbboxOperation()
        {
            //Make a valuetype int variable
            int myInt = 25;

            //Box the int into a object reference
            object boxedInt = myInt;

            //unbox the reference back into a correspoding int
            int unboxedInt = (int)myInt;
        }

        static void WorkWithArrayList()
        {
            //Valuetypes are automatically boxed when
            //passed to a method requesting an object

            ArrayList myInts = new ArrayList();
            myInts.Add(10);
            myInts.Add(20);
            myInts.Add(35);

            //Unboxing occurs when an object is converted 
            //back to stack-based data
            int i = (int)myInts[0];

            //Now it is reboxed, as WriteLine() requires object type!
            Console.WriteLine($"Value of your int: {i}");
        }
    }
}
