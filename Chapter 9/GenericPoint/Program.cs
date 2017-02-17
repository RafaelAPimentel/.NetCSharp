using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Point<int> p = new Point<int>(10, 10);
            Console.WriteLine("p.ToString()={0}",p.ToString());
            p.ResetField();
            Console.WriteLine("p.ToString()={0}",p.ToString());
            Console.WriteLine();

            Point<double> p2 = new Point<double>(5.6, 4.2);
            Console.WriteLine("p.ToString()={0}", p2.ToString());
            p2.ResetField();
            Console.WriteLine("p.ToString()={0}", p2.ToString());
            Console.WriteLine();
            Console.Read();

        }
    }

    public struct Point<T>
    {
        private T xPos;
        private T yPos;

        public Point(T xval, T yval)
        {
            xPos = xval;
            yPos = yval;
        }

        public T X
        {

            get { return xPos; }
            set { xPos = value; }
        }
        public T Y {
            get { return yPos; }
            set { yPos = value; }
        }

        public override string ToString()
        {
            return string.Format("[{0},{1}]", xPos, yPos);
        }

        public void ResetField() {
            xPos = default(T);
            yPos = default(T);
        }
    }
}
