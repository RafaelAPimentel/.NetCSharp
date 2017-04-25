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

        public Point(int xPos, int yPos,string petName) { X = xPos; Y = yPos;desc.PetName = petName; }
        public Point(int xPos,int yPos) { X = xPos; Y = yPos; }
        public Point() { }

        //Override Object.ToString()
        public override string ToString()
        {
            return string.Format($"X= {X}; Y = {Y}; Name = {desc.PetName}; \nID = {desc.PointID} ");
        }

        public object Clone()
        {
            //Use this if the object cntains only value types
            //return this.MemberwiseClone();

            //if the object contains reference types then you have to fill them in 
            //First get shallow copy
            Point newPoint = (Point)this.MemberwiseClone();

            //then fill in the gap
            PointDescription currentDesc = new PointDescription();
            currentDesc.PetName = this.desc.PetName;
            newPoint.desc = currentDesc;
            return newPoint;

        }
    }
}
