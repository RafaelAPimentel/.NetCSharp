using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegularShape = MyShapes;
using ThreeDemensional = My3DShapes;

namespace CustomNamespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            RegularShape.Hexagon hex = new RegularShape.Hexagon();
            RegularShape.Circle Cir = new RegularShape.Circle();
            RegularShape.Square squ = new RegularShape.Square();

            ThreeDemensional.Hexagon hex2 = new ThreeDemensional.Hexagon();
            ThreeDemensional.Circle cir2 = new ThreeDemensional.Circle();
            ThreeDemensional.Square squ2 = new ThreeDemensional.Square();
        }
    }
}
