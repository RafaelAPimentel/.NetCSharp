using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssuesWithNonGenericCollection
{
    class CarCollection : IEnumerable
    {
        private ArrayList arCars = new ArrayList();

        //cast for caller
        public Car GetCar(int pos) {
            return (Car)arCars[pos];
        }

        //insert only car object
        public void AddCar(Car c) {
            arCars.Add(c);
        }
        //clear 
        public void ClearCars() {
            arCars.Clear();
        }

        //count
        public int Count {
            get { return arCars.Count; }
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return arCars.GetEnumerator();
        }

        //IEnumerable
    }
}
