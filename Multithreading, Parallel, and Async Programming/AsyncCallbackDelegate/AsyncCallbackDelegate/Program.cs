using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncCallbackDelegate
{
    public delegate int BinaryOp(int x, int y);
    class Program
    {
        private static bool isDone = false;

        static void Main(string[] args)
        {
            Console.WriteLine("***** AsyncCallbackDelegate Example*****");
            Console.WriteLine($"Main() invoked on thread {Thread.CurrentThread.ManagedThreadId} ");

            BinaryOp b = new BinaryOp(Add);
            IAsyncResult iftAR = b.BeginInvoke(10, 10, new AsyncCallback(AddComplete), null);

            //Assume other work is done here
            while (!isDone)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Working....");
            }
            Console.Read();
        }

        static int Add(int x, int y)
        {
            Console.WriteLine($"Add() invoked on thread {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(5000);
            return x + y;
        }

        static void AddComplete(IAsyncResult iftAR)
        {
            Console.WriteLine($"AddCompete invoked on thread {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine("Your addition is complete");
            isDone = true;
        }
    }
}
