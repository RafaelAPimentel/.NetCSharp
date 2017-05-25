using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with System.GC *****");

            //Print out estimated number of bytes on heap
            Console.WriteLine($"Estimated bytes on heap {GC.GetTotalMemory(false)}");

            //MAx Generation is zero based
            Console.WriteLine($"This OS has {GC.MaxGeneration + 1} max generation");

            Car refToMyCar = new Car("Zippy", 100);
            Console.WriteLine(refToMyCar.ToString());

            //print out generation of refToMyCar is: {0}
            Console.WriteLine($"Generation of refToMyCar is: {GC.GetGeneration(refToMyCar)}");

            //Make a ton of objects for testing purposes
            object[] tonsOfObjects = new object[50000];
            for (int i = 0; i < tonsOfObjects.Length; i++)
            {
                tonsOfObjects[i] = new object(); 
            }

            //collect only gen 0 objects
            GC.Collect(0, GCCollectionMode.Forced);
            GC.WaitForPendingFinalizers();

            //print out generation of refToMyCar
            Console.WriteLine($"Generation of refToMyCar is : {GC.GetGeneration(refToMyCar)}");

            //see if tonsOfObjects[9000] is still alive
            if (tonsOfObjects[9000] != null) {
                Console.WriteLine($"Generation of tonOfObjects[9000] is: {GC.GetGeneration(tonsOfObjects[9000])}");
            }else
            {
                Console.WriteLine($"TonOfObjects[9000] is no longer alive");
            }

            //print out how many times a generation has been swept
            Console.WriteLine($"Gen 0 has been swept {GC.CollectionCount(0)} times");
            Console.WriteLine($"Gen 1 has been swept {GC.CollectionCount(1)} times");
            Console.WriteLine($"Gen 2 has been swept {GC.CollectionCount(2)} times");
            Console.Read();
        }
    }
}
