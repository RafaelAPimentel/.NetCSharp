using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitializers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Objects Init Syntax *****\n");
            //Create point and set property manualy
            Point firstPoint = new Point();
            firstPoint.X = 10;
            firstPoint.Y = 10;
            firstPoint.DisplayStats();

            //Create point via custom constructor
            Point anotherPoint = new Point(20, 20);
            anotherPoint.DisplayStats();

            //Create point using object init
            Point finalPoint = new Point { X = 30, Y = 30 };
            finalPoint.DisplayStats();

            Point goldPoint = new Point(PointColor.Gold) { X = 90, Y = 20 };

            Rectangle rect = new Rectangle
            {
                topLeft = new Point { X = 10, Y = 10 },
                rightBottom = new Point { X = 200, Y = 200 }
            };
            Console.ReadKey();
        }
    }
}
