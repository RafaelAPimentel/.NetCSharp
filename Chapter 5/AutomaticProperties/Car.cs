
using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticProperties
{
    class Garage
    {
        public int NumberOfCars { get; set; } = 0;
        public Car MyAuto { get; set; } = new Car();

        static Garage()
        {
            WriteLine("Creating a garage for your cars");
        }
        public Garage() { }

        public Garage(Car car)
        {
            MyAuto = car;
            NumberOfCars++;
        }
    }

    class Car
    {
        public string PetName { get; set; }
        public int Speed { get; set; }
        public string Color { get; set; }
        public Car() { }
        public Car(string name, int speed, string color)
        {
            PetName = name;
            Speed = speed;
            Color = color;
        }
        public void DisplayStatus()
        {
            WriteLine($"Car Name: {PetName}");
            WriteLine($"Speed: {Speed}");
            WriteLine($"Color: {Color}");
        }
    }
}
