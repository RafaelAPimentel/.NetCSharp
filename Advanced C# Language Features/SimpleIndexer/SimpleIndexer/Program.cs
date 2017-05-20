using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleIndexer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with Indexers ****");

            PersonCollection myPeople = new PersonCollection();

            //add objects with indexers syntax
            myPeople[0] = new Person("Homer", "Simpson", 40);
            myPeople[1] = new Person("Marge", "Simpson", 38);
            myPeople[2] = new Person("Lisa", "Simpson", 9);
            myPeople[3] = new Person("Bart", "Simpson", 7);
            myPeople[4] = new Person("Maggie", "Simpson", 2);

            //Now obtain and display each item using indexer.
            for (int i = 0; i < myPeople.Count; i++)
            {
                Console.WriteLine($"Person number {i}");
                Console.WriteLine($"Name: {myPeople[i].FirstName} {myPeople[i].LastName}");
                Console.WriteLine($"Age: {myPeople[i].Age}");
            }
            Console.WriteLine("**** Using List of People****");
            UseGenericListOfPeople();
            Console.Read();
        }

        static void UseGenericListOfPeople()
        {

            List<Person> myPeople = new List<Person>();
            myPeople.Add(new Person("Lisa", "Simpson", 9));
            myPeople.Add(new Person("Bart", "Simpson",7));

            //change first person with indexer
            myPeople[0] = new Person("Maggie", "Simpson", 2);

            //Now obtain and display each item using indexer
            for (int i = 0; i < myPeople.Count; i++)
            {
                Console.WriteLine($"Person number {i}");
                Console.WriteLine($"Name: {myPeople[i].FirstName} {myPeople[i].LastName}");
                Console.WriteLine($"Age: {myPeople[i].Age}");
            }
        }
    }
}
