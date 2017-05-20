using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    class Program
    {
        static int Add(int x, int y)
        {
            return x + y;
        }
        static double Add(double x, double y)
        {
            return x + y;
        }
        static long Add(long x, long y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(  "Fun with Method Overloading");
            //int Add method
            Console.WriteLine(Add(10,10));
            //double Add method
            Console.WriteLine(Add(10.3,20.5));
            //long Add method
            Console.WriteLine(Add(90000000000000,9000000000));
            Console.ReadLine();
        }
    }
}
