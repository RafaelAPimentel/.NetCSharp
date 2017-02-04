using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithStructures
{
    class Program
    {
        struct Point
        {
            public int x;
            public int y;

            public void increment()
            {
                x++; y++;
            }

            public void decrement()
            {
                x--;y--;
            }

            public void Display()
            {
                Console.WriteLine(  "X : {0}, Y:  {1}", x,y);
            }

            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }




        static void Main(string[] args)
        {
            Point myPoint = new Point(20, 30);
            Console.WriteLine("Original initialization");
            myPoint.Display();

            myPoint.increment();
            Console.WriteLine("After increment");
            myPoint.Display();
            Console.ReadKey();
               
        }
    }
}
