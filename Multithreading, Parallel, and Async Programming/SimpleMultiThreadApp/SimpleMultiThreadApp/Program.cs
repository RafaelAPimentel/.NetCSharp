using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SimpleMultiThreadApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** The Amazing Thread App ****");
            Console.WriteLine("Do you want [1] or [2] threads?");

            string threadCount = Console.ReadLine();

            //Name the current thread
            Thread primaryThread = Thread.CurrentThread;
            primaryThread.Name = "Primary";

            //Display thread info
            Console.WriteLine($"-> {Thread.CurrentThread.Name}");

            //Make worker class
            Printer p = new Printer();

            switch (threadCount) {
                case "2":
                    //Now make the thread.
                    Thread backgorundThread = n ew Thread(new ThreadStart(p.PrintNumbers));
                    backgorundThread.Name = "Secondary";
                    backgorundThread.Start();
                    break;
                case "1":
                    p.PrintNumbers();
                    break;
                default:
                    Console.WriteLine( $"I don't know what you want... you get 1 thread...");
                    goto case "1";
            }
            //Do some additional work
            MessageBox.Show("I'm busy!", "Work on main thread...");
            Console.Read();
        }
    }
}
