using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparableCar
{
    class Car : IComparable, IComparer
    {
        public const int MaxSpeed = 100;

        public int CarID { get; set; }
        public int CurrentSpeed { get; set; } = 0;
        public string PetName { get; set; } = "";
        public static IComparer SortByPetName { get { return (IComparer)new Car(); } }

        private bool carIsDead;

        private Radio theMusicBox = new Radio();

        public Car()
        {

        }
        public Car(string name, int speed,int id)
        {
            PetName = name;
            CurrentSpeed = speed;
            CarID = id;
        }

        public void CrankTunes(bool state) {
            theMusicBox.TurnOn(state);
        }

        public void Accelerate(int delta) {
            if (carIsDead)
                Console.WriteLine("{0} is out of order...", PetName);
            else {
                CurrentSpeed += delta;
                if (CurrentSpeed > MaxSpeed)
                {
                    CurrentSpeed = 0;
                    carIsDead = true;
                    Exception ex = new Exception(string.Format("{0} has over heated!", PetName));
                    ex.HelpLink = "http://carsRus.com";
                    ex.Data.Add("TimeStamp", string.Format("The car exploded at {0}", DateTime.Now));
                    ex.Data.Add("cause", string.Format("You have a lead foot"));
                    throw ex;
                }
                else
                    Console.WriteLine("=> currentSpeed = {0}",CurrentSpeed);
            }
   
        }

        int IComparable.CompareTo(object obj)
        {
            Car temp = obj as Car;
            if (temp != null)
            {
                return this.CarID.CompareTo(temp.CarID);
            }
            else
                throw new ArgumentException("Parameter is not a Car!");

        }

        int IComparer.Compare(object x, object y) {
            Car obj1 = x as Car;
            Car obj2 = y as Car;

            if (obj1 != null && obj2 != null)
            {
                return string.Compare(obj1.PetName, obj2.PetName);
            }
            else {
                throw new ArgumentException("This isnt a Car");
            }
        }
    }
}
