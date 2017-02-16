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
            //UseGenericList();
            //UseGenericStack();
            //UseGenericQueue();
            //UseSortedSet();
            UseDictionary();
            Console.Read();
        }

        static void UseGenericList()
        {
            //Make a list of Person objects init syntax
            List<Person> people = new List<Person>() {
                new Person {FirstName="Homer",LastName="Simpson",Age=47 },
                new Person {FirstName="Marge",LastName="Simpson",Age=45 },
                new Person {FirstName="Lisa",LastName="Simpson",Age=9 },
                new Person {FirstName="Bart",LastName="Simpson",Age=8 }
            };
            //Print out number of items
            Console.WriteLine("Items in list: {0}", people.Count);
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

        static void UseGenericStack()
        {
            Stack<Person> stackOfPerson = new Stack<Person>();
            stackOfPerson.Push(new Person { FirstName = "Homer", LastName = "Simpson", Age = 47 });
            stackOfPerson.Push(new Person { FirstName = "Marge", LastName = "Simpson", Age = 45 });
            stackOfPerson.Push(new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9 });
            stackOfPerson.Push(new Person { FirstName = "Bart", LastName = "Simpson", Age = 8 });

            //Look at the top item pop it off and look again
            Console.WriteLine("First Person is {0}", stackOfPerson.Peek());
            Console.WriteLine("Popped off {0}", stackOfPerson.Pop());
            Console.WriteLine();
            Console.WriteLine("First Person is {0}", stackOfPerson.Peek());
            Console.WriteLine("Popped off {0}", stackOfPerson.Pop());
            Console.WriteLine();
            Console.WriteLine("First Person is {0}", stackOfPerson.Peek());
            Console.WriteLine("Popped off {0}", stackOfPerson.Pop());
            Console.WriteLine();
            Console.WriteLine("First Person is {0}", stackOfPerson.Peek());
            Console.WriteLine("Popped off {0}", stackOfPerson.Pop());

            try
            {
                Console.WriteLine("First Person is {0}", stackOfPerson.Peek());
                Console.WriteLine("Popped off {0}", stackOfPerson.Pop());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error! {0}", ex.Message);
            }


        }

        static void GetCoffee(Person p)
        {
            Console.WriteLine("{0} got coffee", p.FirstName);
        }

        static void UseGenericQueue()
        {
            //Make a Q with hree people
            Queue<Person> PeopleQ = new Queue<Person>();
            PeopleQ.Enqueue(new Person { FirstName = "Homer", LastName = "Simpson", Age = 47 });
            PeopleQ.Enqueue(new Person { FirstName = "Marge", LastName = "Simpson", Age = 47 });
            PeopleQ.Enqueue(new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9 });

            //Peek at first person in queue
            Console.WriteLine("{0} is first in line", PeopleQ.Peek());

            //Remove each person from queue
            GetCoffee(PeopleQ.Dequeue());
            GetCoffee(PeopleQ.Dequeue());
            GetCoffee(PeopleQ.Dequeue());

            //Try to de-Q again
            try
            {
                GetCoffee(PeopleQ.Dequeue());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void UseSortedSet()
        {
            //Make people with different ages
            SortedSet<Person> setOfPerson = new SortedSet<Person>(new SortPeopleByAge())
            {
                new Person { FirstName = "Homer", LastName = "Simpson", Age = 47 },
                new Person { FirstName = "Marger", LastName = "Simpson", Age = 45 },
                new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9 },
                new Person { FirstName = "Bart", LastName = "Simpson", Age = 8 },
            };

            //Noe the items are sorted
            foreach (Person p in setOfPerson)
                Console.WriteLine(p);

            Console.WriteLine();

            //Add a few more people 
            setOfPerson.Add(new Person { FirstName = "Saku", LastName = "Jones", Age = 1 });
            setOfPerson.Add(new Person { FirstName = "Mikko", LastName = "Jones", Age = 32 });

            //Items should still be sorted
            foreach (Person p in setOfPerson)
                Console.WriteLine(p);

            Console.WriteLine();


        }

        private static void UseDictionary()
        {
            //Populate dictionary using add method
            Dictionary<string, Person> PeopleA = new Dictionary<string, Person>();
            PeopleA.Add("Homer", new Person("Homer", "Simpson", 47));
            PeopleA.Add("Marge", new Person("MArge", "Simpson", 45));
            PeopleA.Add("Lisa", new Person("Lisa", "Simpson", 9));

            Person personA = PeopleA["Homer"];
            Console.WriteLine(personA);

            //Another way to initialize dictionary
            //Dictionary<string, Person> peopleB = new Dictionary<string, Person>() {
            //    { "Homer" , new Person {FirstName="Homer",LastName= "Simpson",Age=47 } },
            //    { "Marge", new Person {FirstName="Marge",LastName= "Simpson",Age=45  } },
            //    {"Lisa",new Person { FirstName="Lisa",LastName= "Simpson",Age=9 } }
            //};

            Dictionary<string, Person> peopleC = new Dictionary<string, Person>() {
                 ["homer"] = new Person {FirstName="Homer",LastName= "Simpson",Age=47 }, 
                 ["Marge"] = new Person {FirstName="Marge",LastName= "Simpson",Age=45  },
                ["Lisa"] = new Person { FirstName="Lisa",LastName= "Simpson",Age=9 } 
            };
            Person personB = peopleC["Lisa"];
            Console.WriteLine(personB);
        }
    }
}
