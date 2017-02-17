using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithObservableCollection
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Person() { }
        public Person(string firstname, string lastname, int age) {
            FirstName = firstname;
            LastName = lastname;
            Age = age;
        }

        public override string ToString()
        {
            return string.Format($"FirstName = {FirstName} ,LastName = {LastName}, Age = {Age}");
        }
    }
}
