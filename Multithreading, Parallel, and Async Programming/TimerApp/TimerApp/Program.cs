using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TimerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" **** Working with Timer Type ****");

            //create delegate for the timer type
            TimerCallback timeCB = new TimerCallback(PrintTime);

            //Establish timer settings
            Timer t = new Timer(timeCB,null, 0, 1500);

            Console.WriteLine("Hit key to terminate...");
            Console.Read();
        }

        static void PrintTime(object state) {
            Console.WriteLine($"Time is {DateTime.Now.ToLongTimeString()}");
        }
    }
}
