
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadPoolApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with the CLR Thread Pool****");

            Console.WriteLine($"Main thread started. ThreadID = {Thread.CurrentThread.ManagedThreadId}");

            Printer p = new Printer();

            WaitCallback workItem = new WaitCallback(PrintTheNumbers);

            //Queue the method ten times.
            for (int i = 0; i < 10; i++)
            {
                ThreadPool.QueueUserWorkItem(workItem, p);
            }
            Console.WriteLine("All tasks queued");
            Console.Read();
        }

        static void PrintTheNumbers(object state) {
            Printer task = (Printer)state;
            task.PrintNumbers();   
        }
    }
}
