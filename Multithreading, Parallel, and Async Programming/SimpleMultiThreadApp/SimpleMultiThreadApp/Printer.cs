using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleMultiThreadApp
{
    class Printer
    {
        public void PrintNumbers() {
            //Display Thread info
            Console.WriteLine($"-> {Thread.CurrentThread.Name} is executing PrintNumbers()");

            //print out numbers
            Console.WriteLine("Your numbers: ");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i},");
                Thread.Sleep(2000);
            }
            Console.WriteLine();
        }
    }
}
