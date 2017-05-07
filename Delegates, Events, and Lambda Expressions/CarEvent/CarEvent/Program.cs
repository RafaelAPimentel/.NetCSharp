using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with Events****\n");

            Car c1 = new Car("Slug", 100, 10);

            //Register event handlers
            c1.AboutToBlow += delegate(string msg) {
                Console.WriteLine($"=> Critical Message from Car: {msg}");
            };

            c1.AboutToBlow += CarAboutToBlow;
            c1.Exploded += CarExploded;

            Console.WriteLine("*****Speeding up *****");
            for (int i = 0; i < 6; i++)
            {
                c1.Accelerate(20);
            }

            //remove CarExploded method
            //from invocaton list
            //c1.Exploded -= d;

            //Console.WriteLine($"\n***** Speeding up again ******");
            //for (int i = 0; i < 6; i++)
            //{

            //    c1.Accelerate(20);
            //}

            Console.Read();
        }

        private static void CarExploded(string msgForCaller)
        {
            Console.WriteLine(msgForCaller);
        }

        private static void CarAboutToBlow(string msg)
        {
            Console.WriteLine(msg);
        }

        //This was turned into an anynomous function so it is never called
        private static void CarIsAlmostDoomed(string msg)
        {
            Console.WriteLine($"=> Critical Message from Car: {msg}");
        }

    }
}
