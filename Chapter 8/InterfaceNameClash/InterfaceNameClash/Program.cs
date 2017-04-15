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
            Octogon oct = new Octogon();

            //We not must use cast to access the draw()
            IDrawToForm itfForm = (IDrawToForm)oct;
            itfForm.draw();

            //shorthand notation if you dont need the inerface 
            //variable for later use
            ((IDrawToPrinter)oct).draw();

            //Could as use the is keyword
            if (oct is IDrawToMemory)
                ((IDrawToMemory)oct).draw();
            Console.ReadLine();
        }
    }

    public interface IDrawToForm
    {
        void draw();
    }

    public interface IDrawToMemory
    {

        void draw();
    }

    public interface IDrawToPrinter
    {
        void draw();
    }
}
