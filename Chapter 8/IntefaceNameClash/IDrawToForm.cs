using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceNameClash
{
    interface IDrawToForm
    {
        void draw();
    }

    interface IDrawToMemory
    {
        void draw();
    }

    interface IDrawToPrinter
    {
        void draw();
    }
}
