using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneablePoint
{
    class Program
    {
        static void Main(string[] args)
        {
            //object passed by reference
            Console.WriteLine("****Fun with Object Cloning****");
            Point p1 = new Point(50, 50,"Bob");
            Point p2 = p1;

            p2.X = 0;
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine();

            //using the clone method 
            Point p3 = new Point(100, 100,"Jane");
            Point p4 = (Point)p3.Clone();
            Console.WriteLine("Cloned p3 and stored it in p4\nBefore modification:");
            Console.WriteLine(p3 + "\n");
            Console.WriteLine(p4 + "\n");
            p4.desc.PetName = "My New Point";
            p4.X = 0;
            Console.WriteLine("Changed p4.desc.PetName and p4.X \nAfter Modification:");
            Console.WriteLine(p3);
            Console.WriteLine(p4);
            
            Console.Read();
        }
    }
}
