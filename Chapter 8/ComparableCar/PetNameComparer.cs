using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparableCar
{
    class PetNameComparer : IComparer
    {
        int IComparer.Compare(object x, object y)
        {
            Car t1 = x as Car;
            Car t2 = y as Car;

            if (x != null && y != null)
                return string.Compare(t1.PetName, t2.PetName);
            else
                throw new ArgumentException("Parameter is not a Car!");

        }
    }
}
