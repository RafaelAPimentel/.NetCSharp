using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringIndexer
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Fun with tring indexers");

            PersonCollection myPeople = new PersonCollection();

            myPeople["Homer"] = new Person("Homer", "Simpson", 40);
            myPeople["Marge"] = new Person("Marge", "Simpson", 38);

            foreach(var person in myPeople)
                Console.WriteLine(person.ToString());
            //get homer and print data
            Person homer = myPeople["Homer"];
            Console.WriteLine(homer.ToString());
            Console.Read();
        }
    }
}
