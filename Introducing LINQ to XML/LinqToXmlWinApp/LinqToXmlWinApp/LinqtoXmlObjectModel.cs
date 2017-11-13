using System;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LinqToXmlWinApp
{
    static class LinqtoXmlObjectModel
    {
        public static XDocument GetXmlInventory()
        {
            try
            {
                XDocument inventoryDoc = XDocument.Load("Inventory.xml");
                return inventoryDoc;
            }
            catch (System.IO.FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static void InsertNewElement(string make, string color, string petName){
            //load current document.
            XDocument inventoryDoc = XDocument.Load("Inventory.xml");

            //Get a random  number for the ID.
            Random r = new Random();

            //make a new xElement based on incoming parameters
            XElement newElement = new XElement("Car", new XAttribute("ID", r.Next(50000)),
                new XElement("Color", color),
                new XElement("Make", make),
                new XElement("PetName", petName));

            //Add to in memory object
            inventoryDoc.Descendants("Inventory").First().Add(newElement);

            //davechanges to disk
            inventoryDoc.Save("Inventory.xml");
        }

        public static void LookUpColorsForMake(string make)
        {
            //Load current document
            XDocument inventoryDoc = XDocument.Load("Inventory.xml");

            //Find the colors for a given make.
            var makeInfo = from car in inventoryDoc.Descendants("Car")
                where car.Element("Make")?.Value.ToLower() == make.ToLower()
                select car.Element("Color")?.Value;

            //Build a string representing each color
            var enumerable = makeInfo as string[] ?? makeInfo.ToArray();
            if (!enumerable.Any())
            {
                MessageBox.Show(@"Insert a value homie!");
                return;
            }
            string data = string.Empty;
            foreach (var item in enumerable.Distinct())
            {
                data += string.Format($"- {item}\n");
            }
            
            //Show colors
            MessageBox.Show(data, string.Format($"{make} colors:"));
        }
    }
}
