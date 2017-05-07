using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceHierarchy
{
    class BitMapImage : IAdvancedDraw
    {
        public void draw()
        {
            Console.WriteLine("Drawing....");
        }

        public void DrawInBoundingBox(int top, int left, int botton, int right)
        {
            Console.WriteLine("Drawing in a box...");
        }

        public void DrawUpsideDown()
        {
            Console.WriteLine("Drawing upside down!");
        }
    }
}
