using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIInterfceHiearchy
{
    class Rectangle : IShape
    {
        void IDrawable.Draw()
        {
            Console.WriteLine("Drawing to screen....");        }

        void IPrintable.Draw()
        {
            Console.WriteLine("Drawing to printer...");
        }

        public void Print()
        {
            Console.WriteLine("Printing....");
        }

        public int GetNumberOfSides() {
            return 4;
        }
    }
}
