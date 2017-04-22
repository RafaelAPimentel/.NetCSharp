using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssuesWithNonGenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Custom Person Collection ****\n");
            PersonCollection myPeople = new PersonCollection();
            myPeople.AddPerson(new Person("Homer", "Simpson", 40));
            myPeople.AddPerson(new Person("Marge", "Simpson", 38));
            myPeople.AddPerson(new Person("Lisa", "Simpson", 9));
            myPeople.AddPerson(new Person("Bart", "Simpson", 7));
            myPeople.AddPerson(new Person("Maggie", "Simpson", 2));

            foreach (Person  p  in myPeople)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine();
            Console.WriteLine("**** Fun wih Generics ****\n");
            List<Person> morePeople = new List<Person>();
            morePeople.Add(new Person("Frank", "Black", 50));
            Console.WriteLine(morePeople[0]);

            //This list can only hold integers
            List<int> moreInts = new List<int>();
            moreInts.Add(10);
            moreInts.Add(20);
            int sum = moreInts[0] + moreInts[1];
            Console.WriteLine($"sum: {sum}");
            Console.ReadKey();
        }

        static void SimpleBoxUnbboxOperation()
        {
            //Make a valuetype int variable
            int myInt = 25;

            //Box the int into a object reference
            object boxedInt = myInt;

            //unbox the reference back into a correspoding int
            int unboxedInt = (int)myInt;
        }

        static void WorkWithArrayList()
        {
            //Valuetypes are automatically boxed when
            //passed to a method requesting an object

            ArrayList myInts = new ArrayList();
            myInts.Add(10);
            myInts.Add(20);
            myInts.Add(35);

            //Unboxing occurs when an object is converted 
            //back to stack-based data
            int i = (int)myInts[0];

            //Now it is reboxed, as WriteLine() requires object type!
            Console.WriteLine($"Value of your int: {i}");
        }

        static void ArrayListOfRandomObjects() {
            //The arrayList can hold anything at all
            ArrayList allMyObjects = new ArrayList();
            allMyObjects.Add(true);
            allMyObjects.Add(new OperatingSystem(PlatformID.MacOSX, new Version(10, 0)));
            allMyObjects.Add(66);
            allMyObjects.Add(3.14);

        }
    }
}
