using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ValueAndReferenceTypes
{
    class Program
    {


        struct Point
        {
            public int x; public int y;

            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public void Display()
            {

                Console.WriteLine("X = {0}, Y = {1}", x, y);
            }

        }
        class PointRef
        {
            public int x; public int y;
            public PointRef(int Xpos, int Ypos)
            {
                x = Xpos;
                y = Ypos;

            }

            public void Display()
            {
                Console.WriteLine("X = {0}, Y = {1}", x, y);
            }

        }

        static void ValueTypeAssignments()
        {
            Console.WriteLine("Assigning Value Types");
            Point p = new Point(50, 60);
            Point p2 = p;

            p.Display();
            p2.Display();

            p.x = 100;
            //changing p 
            p.Display();
            p2.Display();
            Console.WriteLine();

        }
        static void ReferenceTypeAssignment()
        {
            Console.WriteLine("Assigning Reference Types");
            PointRef p = new PointRef(50, 60);
            PointRef p2 = p;

            p.Display();
            p2.Display();

            p.x = 100;

            p.Display();
            p2.Display();




        }
        static void Main(string[] args)
        {

            ValueTypeAssignments();
            ReferenceTypeAssignment();
            Console.ReadKey();

        }
    }

}
