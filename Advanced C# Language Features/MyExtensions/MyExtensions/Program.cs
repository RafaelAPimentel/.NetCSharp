using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with Extension Method****");

            int myInt = 12345678;
            myInt.DisplayDefiningAssembly();

            System.Data.DataSet d = new System.Data.DataSet();
            d.DisplayDefiningAssembly();

            System.Media.SoundPlayer sp = new System.Media.SoundPlayer();
            sp.DisplayDefiningAssembly();

            Console.WriteLine($"Value of myInt: {myInt}");
            Console.WriteLine($"Reversed digits of myInt: {myInt.ReverseDigit()}");

            Console.Read();
        }
    }
}
