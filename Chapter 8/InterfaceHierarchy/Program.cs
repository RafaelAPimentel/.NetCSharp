using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Simple Interface Hierarchy ***");
            BitmapImage myBitmap = new BitmapImage();
            myBitmap.draw();
            myBitmap.DrawInBoundingBox(10, 10, 100, 150);
            myBitmap.DrawUpsideDown();

            IAdvancedDraw IAdvDraw = myBitmap as IAdvancedDraw;
            if (IAdvDraw != null)
            {
                IAdvDraw.DrawUpsideDown();
            }
            Console.Read();
        }
    }
}
