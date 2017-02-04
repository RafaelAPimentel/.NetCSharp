using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOverrides
{
    class Person
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string SNN { get; set; } = "";
        public int Age { get; set; }

        public Person(string fname, string lname, int personAge)
        {
            FirstName = fname;
            LastName = lname;
            Age = personAge;
        }
        public Person() { }
        public override int GetHashCode()
        {
            return SNN.GetHashCode();
        }

        public override string ToString()
        {
            string myString;
            myString = string.Format("[First Name: {0}; Last Name{1}; Age{2}]", FirstName, LastName, Age);
            return myString;
        }

        public override bool Equals(object obj)
        {
            return obj.ToString() == this.ToString();
        }




    }
}
