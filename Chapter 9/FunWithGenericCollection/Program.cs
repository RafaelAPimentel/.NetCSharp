using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithGenericCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            UseGenericList();
            Console.Read();
        }

        static void UseGenericList() {
            //Make a list of Person objects init syntax
            List<Person> people = new List<Person>() {
                new Person {FirstName="Homer",LastName="Simpson",Age=47 },
                new Person {FirstName="Marge",LastName="Simpson",Age=45 },
                new Person {FirstName="Lisa",LastName="Simpson",Age=9 },
                new Person {FirstName="Bart",LastName="Simpson",Age=8 }
            };
            //Print out number of items
            Console.WriteLine("Items in list: {0}",people.Count);
            //Enumerate over list
            foreach (Person item in people)
                Console.WriteLine(item);


            //insert a new person
            Console.WriteLine("\nInsert a new person.");
            people.Insert(2, new Person { FirstName = "Maggie", LastName = "Simpson", Age = 2 });

            Console.WriteLine("Items in list {0}", people.Count);

            //copy data into new array
            Person[] arrayOfPeople = people.ToArray();

            for (int i = 0; i < arrayOfPeople.Length; i++)
                Console.WriteLine(arrayOfPeople[i]);
        }
    }
}
