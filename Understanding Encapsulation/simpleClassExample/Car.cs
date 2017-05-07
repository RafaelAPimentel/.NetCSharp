using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleClassExample
{
    class Car
    {
        public string petName;
        public int currSpeed;
        public Car()
        {
            petName = "Chuck Noris"; currSpeed = 10;
        }
        public void printState()
        {
            Console.WriteLine($"{petName} is going {currSpeed} MPH");
        }
        public void speedUp(int delta)
        {
            currSpeed += delta;
        }
    }
}

