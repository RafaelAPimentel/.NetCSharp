using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDelegateMethodGroupCoversion
{
    class Car
    {
        //Internal state data
        public int currentSpeed { get; set; }
        public int MaxSpeed { get; set; }
        public string PetName { get; set; }

        //is car dead
        public bool IsCarDead;

        //Class constructor
        public Car() {

            MaxSpeed = 100;
        }
        public Car(string name, int maxsd, int currsp)
        {
            PetName = name;
            MaxSpeed = maxsd;
            currentSpeed = currsp;
        }

        //define a delegate type
        public delegate void CarEngineHandler(string msgForCaller);

        //Define a member variable for this delegate
        private CarEngineHandler listOfHandler;

        //Add registration function for the caller
        public void RegisterWithCarEngine(CarEngineHandler methodToCall) {
            if (listOfHandler == null)
                listOfHandler = methodToCall;
            else
                listOfHandler += methodToCall;
        }
        public void UnRegisterWithCarEngine(CarEngineHandler methodToCaller){
            listOfHandler -= methodToCaller;
        }

        //Implement the Accelerate() method to invoke the delegate's 
        //invocation list under the correct circumstances.
        public void Accelerate(int delta) {
            //if car is "dead" send dead message
            if (IsCarDead)
            {
                if (listOfHandler != null)
                {
                    listOfHandler("Sorry, Car is dead!");
                }

            }
            else {
                currentSpeed += delta;
                //car is almost dead
                if (10 == MaxSpeed - currentSpeed && listOfHandler != null)
                {
                    listOfHandler("Careful buddy! Gonna blow!");
                }
                if (currentSpeed >= MaxSpeed)
                    IsCarDead = true;
                else
                    Console.WriteLine($"CurrentSpeed: {currentSpeed}");
            }
        }
    }
}
