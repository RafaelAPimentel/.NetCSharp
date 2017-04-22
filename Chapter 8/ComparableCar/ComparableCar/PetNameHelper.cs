using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparableCar
{
    class PetNameHelper : IComparer
    {
        int IComparer.Compare(object obj1, object obj2) {

            Car t1 = obj1 as Car;
            Car t2 = obj2 as Car;

            if (t1 != null && t2 != null)
                return string.Compare(t1.PetName, t2.PetName);
            else
                throw new ArgumentException("PArameter is not a car");

        }
    }
}
