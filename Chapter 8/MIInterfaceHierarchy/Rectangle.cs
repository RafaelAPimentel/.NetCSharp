using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIInterfaceHierarchy
{
    class Rectangle : IShape
    {
        void IPrintable.Draw()
        {
            Console.WriteLine("Drawing to printer...");
        }

        void IDrawable.Draw()
        {
            Console.WriteLine("Drawing on screen..");
        }

        public int GetNumberOfSides()
        {
            return 4;
        }

        void IPrintable.Print()
        {
            Console.WriteLine("Printing...");
        }
    }
}
