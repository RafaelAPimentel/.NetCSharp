using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPoint
{
    struct Point<T>
    {
        //Generic state date
        private T xPos;
        private T yPos;

        //Generic Constructor
        public Point(T xpos, T ypos)
        {
            xPos = xpos;
            yPos = ypos;

        }
        //Generic Properties
        public T X { get { return xPos; } set { xPos = value; } }
        public T Y { get { return yPos; } set { yPos = value; } }
        public override string ToString()
        {
            return string.Format($"[{X},{Y}]");
        }

        //Reset fields to the default value of the
        //type parameter
        public void ResetPoint() {
            X = default(T);
            Y = default(T);
        }
    }
}
