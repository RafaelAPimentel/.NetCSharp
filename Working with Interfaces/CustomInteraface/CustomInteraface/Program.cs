using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInteraface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with Interfaces ****\n");

            //Call Points property defined by Ipointy
            Hexagon hex = new Hexagon();
            Console.WriteLine($"Points: {hex.Points}");
            Console.WriteLine();

            //Catch a possible invalidCastException.
            Circle c = new Circle("Lisa");
            IPointy itfPt = null;
            try
            {
                itfPt = (IPointy)c;
                Console.WriteLine(itfPt.Points);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

            //OBTAINING INTERFACE REFERENCES WITH AS KEY 
            Hexagon hex2 = new Hexagon("Peter");
            IPointy itfpt2 = hex2 as IPointy;

            if (itfpt2 != null)
            {
                Console.WriteLine($"Points: {itfpt2.Points}\n\n");
            }
            else
            {
                Console.WriteLine("OOOPS! Not pointy...");
            }

            //OBTAINING INTERFACE REFERENCE WITH IS KEY

            Shapes[] myShapes = { new Hexagon(), new Circle(), new Triangle("Joe"), new Circle("JoJo"), new ThreeDCircle() };

            foreach (Shapes shape in myShapes)
            {
                Console.WriteLine();
                shape.draw();

                if (shape is IPointy)
                    Console.WriteLine($"-> Points:{((IPointy)shape).Points}");
                else
                    Console.WriteLine($"-> {shape.PetName}\'s not pointy!");

                //PASSING INTERFACE AS PARAMETER IN METHOD
                if (shape is IDraw3D)
                    DrawIn3D((IDraw3D)shape);
            }

            IPointy firstPointyItem = FindFirstPointyShape(myShapes);
            Console.WriteLine($"\nThe firstPointyItem has {firstPointyItem.Points} Points");

            Console.WriteLine("Press Enter to finish console app");
            Console.ReadLine();


        }
        static void DrawIn3D(IDraw3D itf3d)
        {
            Console.WriteLine("-> Drawing IDraw3d compatible type");
            itf3d.Draw3D();
        }
        static IPointy FindFirstPointyShape(Shapes[] shapes)
        {
            foreach (Shapes s in shapes)
                if (s is IPointy)
                    return s as IPointy;
            return null;
        }
    }
}
