using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDispose
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with Dispose ****");

            using (MyResourceWrapper rw = new MyResourceWrapper(),
                rw2 = new MyResourceWrapper())
            {
                //use rw and rw2
            }
            Console.Read();
        }
    }
}
