using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIInterfceHiearchy
{
    interface IDrawable
    {
        void Draw();
    }

    interface IPrintable {
        void Draw();
        void Print();
    }

    interface IShape : IDrawable, IPrintable
    {
        int GetNumberOfSides();
    }
}
