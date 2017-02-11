
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIInterfaceHierarchy
{
    interface IDrawable
    {
        void Draw();
    }

    interface IPrintable
    {
        void Print();
        void Draw(); //<== Possible name clash
    }

    interface IShape : IDrawable, IPrintable
    {

        int GetNumberOfSides();
    }
