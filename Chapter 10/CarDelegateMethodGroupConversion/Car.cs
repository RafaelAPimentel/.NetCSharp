using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDelegateMethodGroupConversion
{
    class Car
    {
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; }
        public string PetName { get; set; }

        //is the car alive or dead
        private bool carIsDead;

        //class constructor
        public Car() { MaxSpeed = 100; }
        public Car(string name, int maxsp, int currsp)
        {
            CurrentSpeed = currsp;
            MaxSpeed = maxsp;
            PetName = name;

        }

        //define a delegate type
        public delegate void CarEngineHandler(string msgForCaller);

        //define a member variable of this delegate
        private CarEngineHandler listOfHandlers;

        //add registratoin function for the caller
        public void RegisterWithCarEngine(CarEngineHandler methodToCall)
        {
            listOfHandlers += methodToCall;
        }

        public void UnRegisterWithCarEngine(CarEngineHandler methodToCall)
        {
            listOfHandlers -= methodToCall;
        }

        //implement the accelerate method to invoke the delegate's invokation list
        //under the correct circumstances
        public void Accelerate(int delta)
        {
            //if the car is dead send dead message
            if (carIsDead)
            {

                return;
            }
            else
            {
                CurrentSpeed += delta;

                if (10 == (MaxSpeed - CurrentSpeed) && listOfHandlers != null)
                {
                    listOfHandlers("Careful buddy! gonna blow!");
                }

                if (CurrentSpeed >= MaxSpeed)
                {
                    carIsDead = true;
                    CurrentSpeed = 0;
                    if (listOfHandlers != null)
                    {
                        listOfHandlers("Sorry, this car is dead... ");

                    }
                }
                else
                    Console.WriteLine("CurrentSpeed = {0}", CurrentSpeed);

            }

        }
    }
}
