using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with conversions ****");
            //make a rectangle 
            Rectangle rect = new Rectangle(15, 4);

            Console.WriteLine(rect.ToString());
            rect.Draw();

            Console.WriteLine();

            //convert r into a square 
            Square squ = (Square)rect;
            Console.WriteLine(squ.ToString());
            squ.Draw();
            Console.WriteLine();
            DrawSquare((Square)rect);
            Console.WriteLine("==========Implicit=====");
            Square s3 = new Square(15);

            //Attempt to make implicit cast
            Rectangle rect2 = (Rectangle)s3;
            Console.WriteLine(rect2.ToString());
            rect2.Draw();
            Console.Read();
        }

        static void DrawSquare(Square sq)
        {
            Console.WriteLine(sq.ToString());
            sq.Draw();
        }
    }
}
