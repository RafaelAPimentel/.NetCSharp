using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExtensions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Extending Interface Compatible Type ****");

            //syatem.array implements IEnumerable
            string[] data = { "Wow", "this", "sort","of","annoying",
                                "but","in","a", "wierd", "way", "fun"};
            data.PrintDataAndBeep();

            Console.WriteLine();

            //List implements IEnumerable
            List<int> myInt = new List<int> { 10, 15, 20 };
            myInt.PrintDataAndBeep();
            Console.Read();
        }
    }
}
