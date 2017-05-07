using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with Generic Structures ****");
            Point<int> p = new Point<int>(10, 20);
            Console.WriteLine($"p.ToString() = {p.ToString()}");
            p.ResetPoint();
            Console.WriteLine($"p.ToString() = { p.ToString()}");
            Console.WriteLine();

            Point<double> p2 = new Point<double>(10.4, 20.4);
            Console.WriteLine($"p2.ToString() = {p2.ToString()}");
            p2.ResetPoint();
            Console.WriteLine($"p2.ToString() = {p2.ToString()}");
            Console.ReadKey();
        }
    }


}
