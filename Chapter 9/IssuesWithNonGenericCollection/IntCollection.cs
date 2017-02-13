using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssuesWithNonGenericCollection
{
    class IntCollection : IEnumerable
    {
        private ArrayList arInt = new ArrayList();

        //GET INT
        public int GetInt(int pos)
        {
            return (int)arInt[pos];
        }

        //INSERT AN INT
        public void AddInt(int i)
        {
            arInt.Add(i);
        }

        //CLEAR THE ARRAY 
        public void ClearInt()
        {
            arInt.Clear();
        }

        //COUNT PROPERTY OF THE ARRAY
        public int Count
        {
            get { return arInt.Count; }
        }

        //IEnumerator
        IEnumerator IEnumerable.GetEnumerator() {
            return arInt.GetEnumerator();
        }
    }
}
