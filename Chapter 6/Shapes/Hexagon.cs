using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Hexagon : Shapes
    {
        public Hexagon()
        {

        }
        public Hexagon(string name)
        :base(name){ }

        public override void draw()
        {
            Console.WriteLine("Drawing {0} the hexagon", PetName);
        }
    }
}
