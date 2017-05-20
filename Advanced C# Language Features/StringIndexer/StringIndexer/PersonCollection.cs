using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringIndexer
{
    class PersonCollection : IEnumerable
    {
        private Dictionary<string, Person> listOfPeople = new Dictionary<string, Person>();

        public Person this[string name] {
            get { return listOfPeople[name]; }
            set { listOfPeople[name] = value; }
        }

        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)listOfPeople).GetEnumerator();
        }
    }
}
