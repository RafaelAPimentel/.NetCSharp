using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssuesWithNonGenericCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            UsePersonCollection();
            Console.Read();
        }

        static void SimpleBoxUnboxOperation()
        {
            // Make a valuetype (int) variable
            int myInt = 25;

            //box the int as an object reference
            object boxedInt = myInt;

            //unbox the reference back into a corresbonding int
            try
            {
                int unboxedInt = (int)boxedInt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        static void WorkWithArrayList() {
            ArrayList myInts = new ArrayList();
            myInts.Add(10);
            myInts.Add(20);
            myInts.Add(35);

            int i = (int)myInts[0];
            
            Console.WriteLine("Value of you int {0}", i);
        }

        static void UsePersonCollection() {
            Console.WriteLine("**** Custom Person Collection ****");
            PersonCollection myPeople = new PersonCollection();
            myPeople.AddPerson(new Person("Homer","Simpson",40));
            myPeople.AddPerson(new Person("Marge", "Simpson", 38));
            myPeople.AddPerson(new Person("Lisa", "Simpson", 9));
            myPeople.AddPerson(new Person("Bart", "Simpson", 7));
            myPeople.AddPerson(new Person("Maggie", "Simpson", 2));

            foreach (Person item in myPeople)
                Console.WriteLine(item);
        }
    }
}
