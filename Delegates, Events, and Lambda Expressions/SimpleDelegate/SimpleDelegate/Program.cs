using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDelegate
{
    //Create delegate that points to any method
    //taking two ints and returning a int
    public delegate int BinaryOp(int x, int y);

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Simple Delegates Examples ****");
            //Create a BinaryOp delegate object that
            //points to simpleMath.Add()
            SimpleMath m = new SimpleMath();
            BinaryOp b = new BinaryOp(m.Add);
            DisplayDelegateInfo(b);
            //Invoke Add() method indirectly using delegate object
            Console.WriteLine($"10 + 10 = {b(10,10)}" );
            Console.WriteLine();
            Console.ReadKey();
        }

        static void DisplayDelegateInfo(Delegate delobj) {
            //print the names of each member in the 
            //delegates invocation list
            foreach (Delegate item in delobj.GetInvocationList())
            {
                Console.WriteLine($"Method Name: {item.Method}");
                Console.WriteLine($"Type Name: {item.Target}");
            }
            
        }
    }
}
