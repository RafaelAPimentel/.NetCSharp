using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicDelegateProblem
{
    class Car
    {
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

        //define a delegate type
        public delegate void CarEngineHandler(string msgForCaller);

        //Define a member variable for this delegate
        public CarEngineHandler listOfHandler;

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
        public void Accelerate(int delta)
        {
            //Just fire the delegate
            if (listOfHandler != null)
            {
                listOfHandler("Sorry, Car is dead!");
            }
        }

    }
}
