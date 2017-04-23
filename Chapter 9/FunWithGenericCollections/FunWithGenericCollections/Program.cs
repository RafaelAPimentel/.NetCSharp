using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithGenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            UseGenericList();
            Console.ReadKey();
        }

        static void UseGenericList()
        {
            //Make a List of Person objects, filled with
            //collection/objectinit syntax
            List<Person> people = new List<Person>() {
                new Person{FirstName="Homer",LastName="Simpson",Age = 47 },
                new Person{FirstName="Marge",LastName="Simpson",Age = 45 },
                new Person{FirstName="Lisa",LastName="Simpson",Age = 9 },
                new Person{FirstName="Bart",LastName="Simpson",Age = 8 }
            };

            //Print out number of items in list
            Console.WriteLine($"Items in list {people.Count}");

            //Enumerate over list
            foreach (Person p in people)
            {
                Console.WriteLine(p);
            }

            //Insert a new Person.
            Console.WriteLine("\n-> Inserting new person.");
            people.Insert(2, new Person { FirstName = "Maggie", LastName = "Simpson", Age = 2 });
            Console.WriteLine($"Items in list {people.Count}");

            Person[] arrayOfPeople = people.ToArray();
            for (int i = 0; i < arrayOfPeople.Length; i++)
            {
                Console.WriteLine($"First Names: {arrayOfPeople[i].FirstName}");
            }
        }
    }
}
