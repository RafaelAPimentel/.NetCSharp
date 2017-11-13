using System;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace ConstructingXmlDocs
{
    static class Program
    {
        static void Main()
        {
            //CreateFullXDocument();
            //CreateRootAndChildren();
            //MakeXElementFromArray();
            ParseAndLoadExistingXml();
            Console.ReadLine();
        }

        private static void ParseAndLoadExistingXml()
        {
            //Build an Xelement from string
            string myElement = @"<Car ID = '3'>
                                      <Color>Yellow</Color>
                                       <Make>Yugo</Make>
                                     </Car>";
            XElement newElement = XElement.Parse(myElement);
            Console.WriteLine(newElement);
            Console.WriteLine();

            //Load the SimpleInventory.xml file
            XDocument myDoc = XDocument.Load("SimpleInventory.xml");
            Console.WriteLine(myDoc);
        }

        private static void CreateFullXDocument()
        {
            XDocument inventoryDoc =
                new XDocument(
                    new XDeclaration("1.0", "utf-8", "Yes"),
                    new XComment("Current Inventory of Cars"),
                    new XProcessingInstruction("xml-stylesheet",
                        "href='MyStyles.css' title='Compact' type='text/css'"),
                    new XElement("Inventory",
                        new XElement("Car", new XAttribute("ID", "1"),
                            new XElement("Color", "Green"),
                            new XElement("Make", "BMW"),
                            new XElement("PetName", "Stan")
                        ),
                        new XElement("Car", new XAttribute("ID", "2"),
                            new XElement("Color", "Pink"),
                            new XElement("Make", "Yugo"),
                            new XElement("PetName", "Melvin")
                        )
                     )
              );

            //save to disk
            inventoryDoc.Save("SimpleInventory.xml");
        }

        private static void CreateRootAndChildren()
        {
            XElement inventoryDoc =
                new XElement("Inventory",
                new XComment("Current inventory of cars!"),
                    new XElement("Car", new XAttribute("ID", "1"),
                    new XElement("Color", "Green"),
                    new XElement("Make", "BMW"),
                    new XElement("PetName", "STan")
                    ),
                    new XElement("Car", new XAttribute("ID", "2"),
                    new XElement("Color", "Pink"),
                    new XElement("Make", "Yugo"),
                    new XElement("PetName", "Melvin")
                    )
                );

            //save to disk
            inventoryDoc.Save("SimpleInventory.xml");
        }

        private static void MakeXElementFromArray()
        {
            //Create an anonymous array of anonymous types
            var people = new[]
            {
                new{FirstName = "Mandy", Age = 32},
                new{FirstName= "Andrew",Age=40},
                new{FirstName= "Dave",Age=41},
                new{FirstName= "Sara",Age=31}
            };

            XElement peopleDoc = 
                new XElement("People",
                    from c in people select new XElement("Person",new XAttribute("Age",c.Age),
                        new XElement("FirstName", c.FirstName))
                );
            Console.WriteLine(peopleDoc);
        }
    }
}
