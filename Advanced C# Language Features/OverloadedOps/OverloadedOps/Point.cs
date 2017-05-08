using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadedOps
{
    class Point : IComparable<Point>
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return string.Format($"[{X},{Y}]");
        }
        public static Point operator +(Point pt1, Point pt2)
        {
            return new Point(pt1.X + pt2.X, pt1.Y + pt2.Y);
        }
        public static Point operator -(Point pt1, Point pt2)
        {
            return new Point(pt1.X - pt2.X, pt1.Y - pt2.Y);
        }
        public static Point operator +(Point pt1, int change)
        {
            return new Point(pt1.X + change, pt1.Y + change);
        }
        public static Point operator +(int change, Point pt1)
        {
            return new Point(pt1.X + change, pt1.Y + change);
        }
        public static Point operator ++(Point p1)
        {
            return new Point(p1.X++, p1.Y++);
        }
        public static Point operator --(Point p1)
        {
            return new Point(p1.X--, p1.Y--);
        }
        public override bool Equals(object obj)
        {
            return this.ToString() == obj.ToString();
        }

        public static bool operator ==(Point p1, Point p2)
        {
            return p1.Equals(p2);
        }
        public static bool operator !=(Point p1, Point p2)
        {
            return !p1.Equals(p2);
        }
        public static bool operator <(Point p1, Point p2)
        {
            return p1.CompareTo(p2) < 0;
        }
        public static bool operator >(Point p1, Point p2)
        {
            return p1.CompareTo(p2) > 0;
        }
        public static bool operator <=(Point p1, Point p2)
        {
            return p1.CompareTo(p2) <= 0;
        }
        public static bool operator >=(Point p1, Point p2)
        {
            return p1.CompareTo(p2) >= 0;
        }
        public int CompareTo(Point other)
        {
            if (this.X > other.X && this.Y > other.Y)
                return 1;
            if (this.X < other.X && this.Y < other.Y)
                return -1;
            else
                return 0;
        }

    }

}
