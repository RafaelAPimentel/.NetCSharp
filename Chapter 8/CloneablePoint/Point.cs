using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneablePoint
{
    class Point : ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public PointDescription desc = new PointDescription();

        public Point() { }
        public Point(int xPos, int yPos,string petName) { X = xPos; Y = yPos;desc.PetName = petName; }

        public override string ToString()
        {
            return string.Format("X = {0}; Y = {1}; Name = {2};\nID = {3}", X, Y,desc.PetName,desc.PointID);
        }
        public object Clone() { Point newPoint = (Point)this.MemberwiseClone();
            PointDescription currDesc = new PointDescription();
            currDesc.PetName = this.desc.PetName;
            newPoint.desc = currDesc;
            return newPoint;
        }
    }
}
