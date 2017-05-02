using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDelegate
{
    class Program
    {
        //Generic delegate can represent any mehod
        //returning void and taking a single parameter of type T
        public delegate void MyGenericDelegate<T>(T arg);
        static void Main(string[] args)
        {
            Console.WriteLine("**** Generic Delegates****");

            //register targets
            MyGenericDelegate<string> strTarget = new MyGenericDelegate<string>(StringTarget);
            strTarget("Some string data\n");

            MyGenericDelegate<int> intTarget = new MyGenericDelegate<int>(IntTarget);
            intTarget(9);
            Console.ReadKey();
        }

        static void StringTarget(string arg)
        {
            Console.WriteLine($"arg in uppercase is: {arg.ToUpper()}");
        }

        static void IntTarget(int arg)
        {
            Console.WriteLine($"++arg in uppercase is :{++arg}");
        }
    }
}
