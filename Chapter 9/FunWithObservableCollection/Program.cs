using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithObservableCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            ObservableCollection<Person> people = new ObservableCollection<Person>() {
                new Person { FirstName="Peter",LastName="Murphy", Age=52},
                new Person { FirstName = "Kevin",LastName="key",Age = 48},
            };

            
            //Wire up the collectionChanged event
            people.CollectionChanged += people_CollectionChanged;
            people.Add(new Person { FirstName = "bill", LastName = "something", Age = 4 });
            people.Remove((Person)people[0]);
            Console.Read();
        }

        static void people_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            //what was the action that ccaused the event
            Console.WriteLine("Action for this event : {0}", e.Action);

            //tehy removed somthing
            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
            {
                Console.WriteLine("Here are the old items");
                foreach (Person p in e.OldItems)
                {
                    Console.WriteLine(p.ToString());
                }
            }

            //tehey add something
            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
            {
                Console.WriteLine("Here are the old items");
                foreach (Person p in e.NewItems)
                {
                    Console.WriteLine(p.ToString());
                }
            }

        }

    }
}
