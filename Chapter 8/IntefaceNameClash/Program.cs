using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceNameClash
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Fun with Interface name clash ***");
            Octogon oct = new Octogon();

            //we need casting to acces the method
            IDrawToForm itfForm = (IDrawToForm)oct;
            itfForm.draw();

            //shorthand notation
            ((IDrawToPrinter)oct).draw();

            //or you could use the is keyword
            if (oct is IDrawToMemory)
                ((IDrawToMemory)oct).draw();

            Console.Read();
        }
    }
}
