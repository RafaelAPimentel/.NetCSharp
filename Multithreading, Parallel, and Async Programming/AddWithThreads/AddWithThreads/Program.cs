using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AddWithThreads
{
    class Program
    {
        static void Main(string[] args)
        {
            AddAsync();
            Console.Read();
        }

        private static async Task AddAsync()
        {
            Console.WriteLine("**** Adding with thread objects ****");
            Console.WriteLine($"ID of thread in Add(): {Thread.CurrentThread.ManagedThreadId}");

            //Make an AddParams object to pass to the secondary thread.
            AddParams ap = new AddParams(10, 10);
            await Sum(ap);

            Console.WriteLine("Other thread is done!");
        }

        static async Task Sum(object data)
        {
            await Task.Run(() =>
            {
                if (data is AddParams)
                {
                    Console.WriteLine($"ID of thread is {Thread.CurrentThread.ManagedThreadId}");

                    AddParams ap = (AddParams)data;
                    Console.WriteLine($"{ap.a} + {ap.b} = {ap.a + ap.b}");

                }
            });

        }
    }
}
 
