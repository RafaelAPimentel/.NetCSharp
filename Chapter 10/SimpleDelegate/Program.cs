using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDelegate
{

    //This deegate can point to any mathod,
    //taking two integers and returning an integer.
    public delegate int BinaryOp(int x, int y);

    //This class contains methods BinaryOp will
    //point to
    public class SimpleMath
    {
        public int Square(int x) {
            return x * x;
        }
        public int Add(int x, int y)
        {
            return x + y;
        }
        public int Subtract(int x, int y)
        {
            return x - y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(  "**** Simple Delegate Example ****");

            //create a BinarOp delegateOp object that
            //points to SipleMath.Add().
            //.Net delegates can also point to instance methods as well
            SimpleMath m = new SimpleMath();
            BinaryOp b = new BinaryOp(m.Add);
            //Invoke Add() method indirectly using delegate object
            DisplayDelegateInfo(b);
            Console.WriteLine("10 + 10 = {0}", b(10,10));
            Console.Read();
        }
        static void DisplayDelegateInfo(Delegate delObj) {
            //Print the names of each member in the 
            //delegate's innvocation list
            foreach (Delegate d in delObj.GetInvocationList())
            {
                Console.WriteLine("Method Name: "+ d.Method);
                Console.WriteLine("Target Name: "+ d.Target);
            }


        }
    }
}
