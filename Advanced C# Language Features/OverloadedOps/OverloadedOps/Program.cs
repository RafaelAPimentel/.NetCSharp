using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadedOps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with Overloaded Operators ****");

            //Make two points
            Point ptOne = new Point(100, 100);
            Point ptTwo = new Point(40, 40);
            Console.WriteLine($"ptOne = {ptOne}");
            Console.WriteLine($"ptTwo = {ptTwo}");

            //add both point classes
            Console.WriteLine($"ptOne + ptTwo = {ptOne+ptTwo}");

            //prints [110,110]
            Point BiggerPoint = ptOne + 10;
            Console.WriteLine($"Bigger point = {BiggerPoint}");

            //prints [120,120]
            Console.WriteLine($"Biggest point = { BiggerPoint+10} ");
            Console.WriteLine("APPLYING THE ++ AND -- UNARY OPERATORS TO A POINT");
            Point ptFive = new Point(1, 1);
            Console.WriteLine($"++ptFive = {++ptFive}");
            Console.WriteLine($"--ptFive = {--ptFive}");
            Point ptSix = new Point(20, 20);
            Console.WriteLine($"ptSix++ = {ptSix++}");
            Console.WriteLine($"ptSix-- = {ptSix--}\n");
            Console.WriteLine($"ptOne == ptTwo: {ptOne==ptTwo}");
            Console.WriteLine($"ptOne == ptTwo: {ptOne != ptTwo}");
            Console.Read();
        }
    }
}
