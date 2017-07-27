using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SyncDelegateReview
{
    public delegate int BinaryOp(int x, int y);
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Synch Delegate Review");

            //Print out the ID of the executing thread
            Console.WriteLine($"Main() invoked on thread {Thread.CurrentThread.ManagedThreadId}");

            //Invoke Add() in syncronous manner
            BinaryOp b = new BinaryOp(Add);

            //Could also write b.invoke(10,10);
            int answer = b(10, 10);

            //These lines will not execute until
            //the Add() method has completed
            Console.WriteLine("Doing more work in main()!");
            Console.WriteLine($"10 + 10 is {answer}.");
            Console.Read();
        }

        static int Add(int x, int y ) {
            //print out the OD of the executing thread
            Console.WriteLine($"Add() invoked on thread {Thread.CurrentThread.ManagedThreadId}");

            Thread.Sleep(5000);
            return x + y;
        }
    }
}
