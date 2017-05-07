using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceNameClash
{
    class Octogon : IDrawToForm, IDrawToMemory, IDrawToPrinter
    {
        void IDrawToForm.draw()
        {
            Console.WriteLine("Drawing the octogon");

        }
        void IDrawToMemory.draw()
        {
            Console.WriteLine("Drawing the octogon");
        }
        void IDrawToPrinter.draw()
        {
            Console.WriteLine("Drawing the octogon");
        }
    }
}
