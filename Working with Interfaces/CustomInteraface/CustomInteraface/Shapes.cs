using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInteraface
{
    abstract class Shapes
    {
        public Shapes(string name = "No Name") { PetName = name; }
        public string PetName { get; set; }
        public abstract void draw();
    }
}
