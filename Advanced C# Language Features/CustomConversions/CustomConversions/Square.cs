using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomConversions
{
    public struct Square
    {
        public Square(int length) : this()
        {
            Length = length;
        }

        public int Length { get; set; }

        public void Draw()
        {
            for (int i = 0; i < Length; i++)
            {
                for (int z = 0; z < Length; z++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public override string ToString()
        {
            return string.Format($"[Length = {Length}]");
        }
        //Rectangle can be explicitly converted
        //into Squares
        public static explicit operator Square(Rectangle rect)
        {
            Square s = new Square();
            s.Length = rect.Height;
            return s;
        }

        public static explicit operator Square(int i)
        {
            Square newSq = new Square();
            newSq.Length = i;
            return newSq;
        }

        public static explicit operator int(Square sq)
        {
            return sq.Length;
        }

    }
}
