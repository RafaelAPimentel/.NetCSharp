using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIInterfceHiearchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle();

            ((IDrawable)rec).Draw();
            ((IPrintable)rec).Draw();
            ((IPrintable)rec).Print();
            Console.WriteLine(rec.GetNumberOfSides());
            Console.ReadKey();
        }
    }
}
