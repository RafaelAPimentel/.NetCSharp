using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleIndexer
{
    class PersonCollection : IEnumerable
    {
        private ArrayList arPeople = new ArrayList();
        public Person this[int index]
        {
            get { return (Person)arPeople[index]; }
            set { arPeople.Insert(index, value); }
        }
        //Cast for caller
        public Person GetPerson(int pos)
        {
            return (Person)arPeople[pos];
        }
        //Insert only Person object
        public void AddPerson(Person p)
        {
            arPeople.Add(p);

        }

        public void ClearPeople()
        {
            arPeople.Clear();
        }

        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)arPeople).GetEnumerator();
        }

        public int Count
        {
            get { return arPeople.Count; }
        }


    }
}
