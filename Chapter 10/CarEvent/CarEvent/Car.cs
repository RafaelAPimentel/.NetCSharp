using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarEvent
{
    class Car
    {
        //define a delegate type
        public delegate void CarEngineHandler(string msgForCaller);

        public event CarEngineHandler Exploded;
        public event CarEngineHandler AboutToBlow;

        //Internal state data
        public int currentSpeed { get; set; }
        public int MaxSpeed { get; set; }
        public string PetName { get; set; }

        //is car dead
        private bool IsCarDead;

        //Class constructor
        public Car() { }
        public Car(string name, int maxsd, int currsp)
        {
            PetName = name;
            MaxSpeed = maxsd;
            currentSpeed = currsp;
        }

        //Implement the Accelerate() method to invoke the delegate's 
        //invocation list under the correct circumstances.
        public void Accelerate(int delta)
        {
            //if car is "dead" fire exploded event
            if (IsCarDead)
            {
                Exploded?.Invoke("Sorry, this car is dead!");
            }
            else
            {
                currentSpeed += delta;
                //car is almost dead
                if (10 == MaxSpeed - currentSpeed )
                {
                    AboutToBlow?.Invoke("Careful buddy! Gonna blow!");
                }
                if (currentSpeed >= MaxSpeed)
                    IsCarDead = true;
                else
                    Console.WriteLine($"CurrentSpeed: {currentSpeed}");
            }
        }
    }
}
