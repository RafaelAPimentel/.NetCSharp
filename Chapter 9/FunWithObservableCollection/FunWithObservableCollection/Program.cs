using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace FunWithObservableCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            //Make a collection to observe and add a few Person objects.
            ObservableCollection<Person> people = new ObservableCollection<Person>() {
                new Person {FirstName="Peter", LastName="Murphy", Age=52 },
                new Person{ FirstName="Kevin",LastName="Key",Age=48},
            };

            //Wire up the collectionChanged event
            people.CollectionChanged += people_CollectionChanged;

            people.Add(new Person("Frank", "Bomb", 45));
            people.Add(new Person("Bill", "Nye", 10));
            //First use of Lambda :) 
            people.Remove(people.ToList().Find(x=>x.FirstName == "Bill"));

            List<Person> listOfPeople = people.ToList();
            foreach (Person item in listOfPeople)
            {
                Console.WriteLine(item.ToString());
            }

            Console.ReadKey();
        }

        static void people_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            ////What was the action that caused the event
            Console.WriteLine($"Action for this event: {e.Action}");

            //They removed something
            if (e.Action == NotifyCollectionChangedAction.Remove)
            {
                Console.WriteLine("Here are the Old Items:");
                foreach (Person p in e.OldItems)
                {
                    Console.WriteLine(p.ToString());
                }
                Console.WriteLine();
            }

            //They added something
            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                Console.WriteLine("Here are the New Items:");
                foreach (Person p in e.NewItems)
                {
                    Console.WriteLine(p.ToString());
                }
            }
        }
    }
}
