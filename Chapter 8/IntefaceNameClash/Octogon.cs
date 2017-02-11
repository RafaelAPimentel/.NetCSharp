using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceNameClash
{
    class Octogon: IDrawToForm, IDrawToMemory, IDrawToPrinter
    {
        void IDrawToForm.draw() {
            Console.WriteLine("Drawing to Form..."); 
        }
        void IDrawToMemory.draw()
        {
            Console.WriteLine("Drawing to Memory...");
        }
        void IDrawToPrinter.draw() {
            Console.WriteLine("Drawing to Printer...");
        }

    }
}
