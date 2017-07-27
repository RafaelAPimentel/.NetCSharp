using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadStats
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Primary Thread stats ****");

            //Obtain and name the current thread
            Thread primaryThread = Thread.CurrentThread;
            primaryThread.Name = "ThePrimaryThread";

            //show details of hosting AppDomain/Context
            Console.WriteLine($"Name of current AppDomain {Thread.GetDomain().FriendlyName}");
            Console.WriteLine($"ID of current Context: {Thread.CurrentContext.ContextID}");

            //print out some stats about the thread
            Console.WriteLine($"Thread Name: {primaryThread.Name}");
            Console.WriteLine($"Has thread started?: {primaryThread.IsAlive}");
            Console.WriteLine($"Priority Level: {primaryThread.Priority}");
            Console.WriteLine($"Thread State: {primaryThread.ThreadState}");
            Console.Read();
        }
    }
}
