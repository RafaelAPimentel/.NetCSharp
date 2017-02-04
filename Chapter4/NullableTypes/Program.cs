using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    class Program
    {
        static void TesterMethod(string[] args)
        {
            Console.WriteLine($"You sent {args?.Length ?? 0} arguments in this method.");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("*******Testing Nullable value*******");
            string[] str = { "hello", "world" };
            Console.WriteLine("Using array with two strings");
            TesterMethod(str);
            Console.WriteLine("Using null");
            TesterMethod(null);
            Console.ReadKey();

        }
    }
}
