using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Fun with Interface ***");
            Hexagon hex = new Hexagon();
            Console.WriteLine("Points {0}", hex.Points);

            Circle c = new Circle("Lisa");
            IPointy itfPt = null;
            try
            {
                itfPt = (IPointy)c;
                Console.WriteLine(itfPt.Points);
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }

            Hexagon hex2 = new Hexagon("Peter");
            IPointy itfPt2 = hex as IPointy;

            if (itfPt2 != null)
                Console.WriteLine("Points: {0} \n", itfPt2.Points);
            else
                Console.WriteLine("OOPS! Not pointy...\n");

            Shapes[] groupShape = { new Hexagon(), new Circle("Bob"), new Triangle("Jojo"), new ThreeDCircle() };

            foreach (Shapes shape in groupShape)
            {
                shape.draw();
                if (shape is IPointy)
                {
                    Console.WriteLine("-> Points: {0}", ((IPointy)shape).Points);
                }
                if (shape is IDraw3D)
                {
                    DrawIn3D((IDraw3D)shape);
                }

                IPointy firstPointyItem = FindFirstPointyShape(groupShape);
                Console.WriteLine("The item has {0} points",firstPointyItem.Points);
                Console.WriteLine();
            }

            IPointy[] myPointyObjects = { new Hexagon(), new Knife(), new Triangle(), new Fork(), new PitchFork() };
            foreach (IPointy i in myPointyObjects)
                Console.WriteLine("Object has {0} points.\n", i.Points);

            Console.Read();
        }

        static void DrawIn3D(IDraw3D itf3d)
        {
            Console.WriteLine("-> Drawing IDraw3D compatible type");
            itf3d.Draw3D();
        }

        static IPointy FindFirstPointyShape(Shapes[] shapes)
        {
            foreach (Shapes shape in shapes)
            {
                if (shape is IPointy)
                    return shape as IPointy;


            }
            return null;
        }
    }
}
