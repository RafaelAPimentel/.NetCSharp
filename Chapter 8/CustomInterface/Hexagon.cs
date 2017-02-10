using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    class Hexagon : Shapes, IPointy
    {
        public Hexagon() { }
        public Hexagon(string name) : base(name) { }
        public override void draw()
        {
            Console.WriteLine("Drawing {0} the Hexagon", PetName);
        }

        public byte Points
        {
            get { return 6; }
        }

    }
}
