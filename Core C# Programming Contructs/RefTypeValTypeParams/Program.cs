using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefTypeValTypeParams
{
    class Person
    {
        public string personName;
        public int personAge;

        public Person(string name, int age)
        {
            personName = name;
            personAge = age;
        }

        public Person()
        {

        }

        public void Display()
        {
            Console.WriteLine("Name: {0}, Age: {1}", personName, personAge);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********Passing person object by value*******");
            Person fred = new Person("fred", 12);
            Console.WriteLine("Before by value call, Person is:");
            fred.Display();
            SendAPersonByValue(fred);
            Console.WriteLine("After by value call, Person is:");
            fred.Display();
            Console.WriteLine("**********************************************");
            Console.WriteLine("******Passing person object by reference******");
            Person mel = new Person("mel", 23);
            Console.WriteLine("Before by ref call, Person is:");
            mel.Display();
            SendAPersonByReference(ref mel);
            Console.WriteLine("After by ref call, Person is:");
            mel.Display();
            Console.WriteLine("**********************************************");

            Console.ReadKey();


        }

        static void SendAPersonByValue(Person p)
        {
            p.personAge = 99;

            p = new Person("Nikki", 99);

        }

        static void SendAPersonByReference(ref Person p)
        {
            p.personAge = 555;
            p = new Person("Nikki", 999);
        }
    }

}
