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
            Console.WriteLine("**** Simple Interface Hierarchy ****");

            BitMapImage myBitImage = new BitMapImage();

            //callin methods from object levlel
            myBitImage.draw();
            myBitImage.DrawInBoundingBox(10,10,100,150);
            myBitImage.DrawUpsideDown();

            //CAlling from IAdvancedDraw Explicitly
            IAdvancedDraw iAdvDraw = myBitImage as IAdvancedDraw;

            if (iAdvDraw != null)
                iAdvDraw.DrawUpsideDown();

            Console.ReadLine();

        }
    }
}
