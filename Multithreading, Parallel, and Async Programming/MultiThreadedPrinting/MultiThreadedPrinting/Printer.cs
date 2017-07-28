using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreadedPrinting
{
    class Printer
    {

        public void PrintNumbers() {
            //Display Thread info
            Console.WriteLine($"-> {Thread.CurrentThread.Name} is executing PrintNumbers()");

            //print out numbers
            Console.Write("Your numbers: ");

            for (int i = 0; i < 10; i++)
            {
                //put thread to sleep for a random amount of time
                Random r = new Random();
                Thread.Sleep(1000 * r.Next(5));
                Console.Write($"{i}");
            }
            Console.WriteLine();
        }
    }
}
