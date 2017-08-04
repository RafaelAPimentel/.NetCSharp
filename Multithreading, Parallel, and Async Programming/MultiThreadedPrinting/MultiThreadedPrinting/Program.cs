using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreadedPrinting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Syncronizing Threads ****\n");
            Printer p = new Printer();

            //Make 10 threads that are all pointing to the same 
            //method on the same object
            Thread[] threads = new Thread[10];
            for (int i = 0; i < 10; i++)
            {
                threads[i] = new Thread(new ThreadStart(p.PrintNumbers));
                threads[i].Name = string.Format($"Working thread #{i}");
            }

            //now start each one
            foreach (Thread t in threads)
                t.Start();
            Console.Read();
        }
    }
}