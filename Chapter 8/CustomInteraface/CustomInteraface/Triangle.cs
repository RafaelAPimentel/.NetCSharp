using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInteraface
{
    class Triangle : Shapes, IPointy
    {
        public Triangle() { }
        public Triangle(string name) : base(name) { }
        public override void draw()
        {
            Console.WriteLine($"Drawing {PetName} the Triangle");
        }

        public byte Points {
            get { return 3; }
        }

    }
}
