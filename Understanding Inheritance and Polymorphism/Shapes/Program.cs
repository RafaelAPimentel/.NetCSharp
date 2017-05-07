using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {

            Shapes[] myShapes = { new Hexagon(), new Circle(), new Hexagon("Beth"), new Circle("Mike"), new Hexagon("Linda") };

            foreach (Shapes s in myShapes)
            {
                s.draw();
            }
            Console.Read();
        }
    }
}
