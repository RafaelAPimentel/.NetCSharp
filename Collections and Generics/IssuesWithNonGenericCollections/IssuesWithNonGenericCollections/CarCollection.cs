using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssuesWithNonGenericCollections
{
    class Car { }
    class CarCollection : IEnumerable
    {

        private ArrayList arCar = new ArrayList();

        //Cast for Caller
        public Car GetCar(int pos) { return (Car)arCar[pos]; }

        //Insert Car
        public void AddCar(Car c) { arCar.Add(c); }

        //Remove all elements
        public void ClearCars() { arCar.Clear(); }

        //return arCar Size
        public int Count { get { return arCar.Count; } }

        //Foreach enumeration support
        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)arCar).GetEnumerator();
        }
    }

}
