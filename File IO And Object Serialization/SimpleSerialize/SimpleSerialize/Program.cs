using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SimpleSerialize
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with Object Serialization ****");

            //Make a JamesBondCar and set state
            JamesBondCar jbc = new JamesBondCar();
            jbc.canFly = true;
            jbc.canSubmerge = false;
            jbc.theRadio.stationPresets = new double[] { 89.3, 105.1, 97.1 };
            jbc.theRadio.hasTweeters = true;

            //Now save the car to a specific file in whichever format
            SaveAsBinaryFormat(jbc, "CarData.dat");
            SaveAsSoapFormat(jbc, "SoapCarData.soap");
            SaveAsXmlFormat(jbc, "XmlCarData.xml");
            SaveListOfCar();
            SaveListOfCarsAsBinary();
            Console.Read();
        }

        private static void SaveListOfCarsAsBinary()
        {
            List<JamesBondCar> myCars = new List<JamesBondCar>() {
                new JamesBondCar{ canFly =true,canSubmerge =true},
                new JamesBondCar{ canFly =true,canSubmerge =false},
                new JamesBondCar{ canFly =false,canSubmerge =true},
                new JamesBondCar{ canFly =false,canSubmerge =false},
            };
            BinaryFormatter binForamt = new BinaryFormatter();
            using (Stream fStream = new FileStream("AllMyCars.dat",FileMode.Create,FileAccess.Write,FileShare.None))
            {
                binForamt.Serialize(fStream, myCars);
            }
            Console.WriteLine("=> Saved list of cars in binary");
        }

        static void SaveListOfCar()
        {
            //Now persist a List<T> of JamesBondCars.
            List<JamesBondCar> myCars = new List<JamesBondCar>() {
                new JamesBondCar{ canFly =true,canSubmerge =true},
                new JamesBondCar{ canFly =true,canSubmerge =false},
                new JamesBondCar{ canFly =false,canSubmerge =true},
                new JamesBondCar{ canFly =false,canSubmerge =false},
            };

            using (Stream fStream = new FileStream("CarCollection.xml", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                XmlSerializer xmlFormat = new XmlSerializer(typeof(List<JamesBondCar>));
                xmlFormat.Serialize(fStream, myCars);
            }
            Console.WriteLine("=> Saved list of Cars!!");

        }

        private static void SaveAsXmlFormat(object objGraph, string fileName)
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(JamesBondCar));

            using (Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                xmlFormat.Serialize(fStream, objGraph);
            }
            Console.WriteLine("=> Saved car as XML format");
        }

        private static void SaveAsSoapFormat(object objGraph, string fileName)
        {
            SoapFormatter soapFormat = new SoapFormatter();

            using (Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                soapFormat.Serialize(fStream, objGraph);
            }
            Console.WriteLine("=> Saved car as SOAP format");
        }

        static void LoadFromBinaryFile(string fileName)
        {
            BinaryFormatter binFormatter = new BinaryFormatter();

            //Read the JamesBondCar from the binary file
            using (Stream fStream = File.OpenRead(fileName))
            {
                JamesBondCar carFromDisk = (JamesBondCar)binFormatter.Deserialize(fStream);
                Console.WriteLine($"Can this car fly? : {carFromDisk.canFly}");
            }
        }
        private static void SaveAsBinaryFormat(object objGraph, string fileName)
        {
            //Save object to a file named carData.dat in binary format
            BinaryFormatter binFormat = new BinaryFormatter();

            using (Stream fStream = new FileStream(fileName, FileMode
                .Create, FileAccess.Write, FileShare.None))
            {
                binFormat.Serialize(fStream, objGraph);
            }
            Console.WriteLine("=> Saved a car in binary format!");
        }
    }
}
