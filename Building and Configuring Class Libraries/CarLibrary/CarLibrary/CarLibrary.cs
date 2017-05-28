using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarLibrary
{
    public enum EngineState {
        engineAlive,engineDead
    }
    public abstract class Car
    {
        public string PetName { get; set; }
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; }

        protected EngineState engState = EngineState.engineAlive;
        public EngineState EngineState {
            get { return engState; }
        }
        public abstract void TurboBoost();
        public Car() {
            Console.WriteLine("Assembly 2.0");
        }

        public Car(string petName, int currentSpeed, int maxSpeed)
        {
            Console.WriteLine("Assembly 2.0");
            PetName = petName;
            CurrentSpeed = currentSpeed;
            MaxSpeed = maxSpeed;
        }

        public void TurnOnRadio(bool musicOn, MusicMedia mm)
        {
            if (musicOn)
            {
                MessageBox.Show(string.Format($"Jammming {mm}"));
            }
            else
            {
                MessageBox.Show("Quiet time...");
            }
        }
    }
}
