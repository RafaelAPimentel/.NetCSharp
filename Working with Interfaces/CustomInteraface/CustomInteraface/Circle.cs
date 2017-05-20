using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInteraface
{
    class Circle : Shapes
    {

        public Circle()
        {

        }
        public Circle(string name)
        :base(name){ }

        public override void draw()
        {
            Console.WriteLine("Drawing {0} the Circle", PetName);
        }


    }
}
