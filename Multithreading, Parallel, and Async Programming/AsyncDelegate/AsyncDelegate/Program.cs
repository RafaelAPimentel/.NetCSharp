using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncDelegate
{
    class Program
    {
        public delegate int BinaryOp(int x, int y);
        static void Main(string[] args)
        {
            Console.WriteLine("***** Async Delegate Invocation *****");

            //print out ID of executing thread
            Console.WriteLine($"Main() invoked on thread {Thread.CurrentThread.ManagedThreadId}");

            //Invoke the Add() method on secondary thread
            BinaryOp b = new BinaryOp(Add);
            IAsyncResult iftAR = b.BeginInvoke(10, 10, null, null);

            while (!iftAR.IsCompleted)
            {
                //Do other work on primary thread...
                Console.WriteLine("Doing more work in Main()");
                Thread.Sleep(1000);
            }

            //obtain the result of Add()
            //Method when ready
            int answer = b.EndInvoke(iftAR);
            Console.WriteLine($"10 + 10 is {answer}");
            Console.Read();
        }

        static int Add(int x, int y)
        {
            Console.WriteLine($"Add() invoked on thread {Thread.CurrentThread.ManagedThreadId}");

            Thread.Sleep(5000);
            return x + y;
        }
    }
}
