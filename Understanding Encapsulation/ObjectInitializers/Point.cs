using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitializers
{
    enum PointColor
    {
        lightBlue, BloodRed, Gold
    }
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public PointColor Color { get; set; }

        public Point(int xVal, int yVal)
        {
            X = xVal;
            Y = yVal;
            Color = PointColor.Gold;
        }

        public Point(PointColor ptColor)
        {
            Color = ptColor;
        }

        public Point()
        : this(PointColor.BloodRed) { }

        public void DisplayStats()
        {
            Console.WriteLine("[{0},{1}]", X, Y);
            Console.WriteLine("Point is {0}", Color);
        }

    }
    class Rectangle
    {
        public Point topLeft { get; set; }
        public Point rightBottom { get; set; }

        public void DisplayStatus()
        {
            Console.WriteLine($"TopLeft: {topLeft.X},{topLeft.Y},{topLeft.Color}");
            Console.WriteLine($"RightBottom{rightBottom.X},{rightBottom.Y},{rightBottom.Color}");
        }
    }
}
