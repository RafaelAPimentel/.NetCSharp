using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;

namespace CustomSerializable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with Custom Serialization ****");

            //Recall that this implements ISerializable
            StringData myData = new StringData();

            //Save to local file in Soap format
            SoapFormatter soapFormat = new SoapFormatter();
            using (Stream fStream = new FileStream("MyData.soap",FileMode.Create,FileAccess.Write,FileShare.None))
            {
                soapFormat.Serialize(fStream, myData);
            }
            Console.Read();
        }
    }
}
