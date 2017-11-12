using System.Xml;
using System.Xml.Linq;

namespace LINQtoXMLFirstLook
{
    static class Program
    {
        static void Main()
        {
            BuildXmlDocWithDom();
            BuildXmldocwithLinqToXml();
        }

        private static void BuildXmldocwithLinqToXml()
        {
            //Create an XML document in a more function manner
            XElement doc = new XElement("inventory",
                new XElement("Car", new XAttribute("ID", "1000"),
                    new XElement("PetName", "Jimbo"),
                    new XElement("Color", "Red"),
                    new XElement("Make", "Ford")
                )
            );

            doc.Save("InventoryWithLINQ.xml");
        }
        private static void BuildXmlDocWithDom()
        {
            //Make a new XML document in memory
            XmlDocument doc = new XmlDocument();

            //Fill the document with a root element
            //named <Inventory>
            XmlElement inventory = doc.CreateElement("Inventory");

            //Now make a subelement named <Car> with
            //ID attribute
            XmlElement car = doc.CreateElement("Car");
            car.SetAttribute("ID", "1000");

            //Build the data within the <Car> element.
            XmlElement name = doc.CreateElement("PetName");
            name.InnerText = "Jimbo";
            XmlElement color = doc.CreateElement("Color");
            color.InnerText = "Red";
            XmlElement make = doc.CreateElement("Make");
            make.InnerText = "Ford";

            //Add <PetName>,<Color>, and <Make> to the <Car> element
            car.AppendChild(name);
            car.AppendChild(color);
            car.AppendChild(make);

            //Add the <Car element to the <Inventory> element
            inventory.AppendChild(car);

            //Insert the complete xml into the xmldocument object
            //and save to file(will be in the debug folder)
            doc.AppendChild(inventory);
            doc.Save("Inventory.xml");

        }
    }



}
