using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    class Triangle : Shapes, IPointy
    {
        public Triangle() { }
        public Triangle(string name) : base(name) { }
        public override void draw()
        {
            Console.WriteLine("Drawing {0} the Triangle", PetName);

        }
        public byte Points
        {
            get { return 3; }
        }
    }
}
