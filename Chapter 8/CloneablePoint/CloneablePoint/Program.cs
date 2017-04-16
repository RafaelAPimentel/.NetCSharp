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
            Console.WriteLine("*** Fun with object cloning ****\n");

            Point p1 = new Point(50, 50);
            Point p2 = p1;
            Point p3 = new Point(100, 100,"Jane");
            Point p4 = (Point)p3.Clone();

            p2.X = 0;
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine();

            Console.WriteLine("Before Modification");
            Console.WriteLine($"p3: {p3}");
            Console.WriteLine($"p4: {p4}");

            p4.desc.PetName = "My New Point";
            p4.X = 9;

            Console.WriteLine("\nChanged p4.desc.PetName and p4.X");
            Console.WriteLine("After Modification");
            Console.WriteLine($"p3: {p3}");
            Console.WriteLine($"p4: {p4}");

            Console.ReadLine();
        }
    }
}
