using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConfigReaderApp
{
    class Program
    {
 
        
        static void Main(string[] args)
        {
            Console.WriteLine("**** Reading <appSettings> Data ****");
            //Get our custom data from the *.config file
            AppSettingsReader ar = new AppSettingsReader();
            int numberOfTimes = (int)ar.GetValue("RepeatCount", typeof(int));
            string textColor = (string)ar.GetValue("TextColor", typeof(string));
            Console.ForegroundColor =  (ConsoleColor)Enum.Parse(typeof(ConsoleColor),textColor);

            for (int i = 0; i < numberOfTimes; i++)
            {
                Console.WriteLine("Howdy!");
            }
            Console.Read();
            
        }
    }
}
