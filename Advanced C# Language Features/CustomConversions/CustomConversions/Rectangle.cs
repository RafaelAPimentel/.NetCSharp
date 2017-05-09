using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomConversions
{
    public struct Rectangle
    {


        public int Width { get; set; }
        public int Height { get; set; }
        public static  int counter = 0;
        public Rectangle(int width, int height) : this()
        {
            Width = width;
            Height = height;
        }
        
        public void Draw() {
            for (int i = 0; i < Height; i++)
            {
                for (int z = 0; z < Width; z++)
                {
                    Console.Write("*");
                }
                counter++;
                Console.WriteLine();
            }
            
        }

        public override string ToString()
        {
            return string.Format($"[Width = {Width}; Height = {Height}]");
        }

        public static implicit operator Rectangle(Square v)
        {
            return new Rectangle(v.Length *2, v.Length);
        }
    }

    
}
