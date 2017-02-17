using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithObservableCollection
{
    class PersonCollection : IEnumerable<Person>
    {
        List<Person> arPeople = new List<Person>();

        public Person GetPerson(int pos) {
            return (Person)arPeople[pos];
        }
        public void Add(Person p) {
            arPeople.Add(p);
        }

        public void ClearPeople() {
             arPeople.Clear();
        }

        public int Count {
            get { return arPeople.Count; }
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return arPeople.GetEnumerator();
        }

        IEnumerator<Person> IEnumerable<Person>.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
