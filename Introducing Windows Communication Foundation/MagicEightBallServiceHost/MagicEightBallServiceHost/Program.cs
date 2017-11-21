using MagicEightBallServiceLib;
using System;
using System.ServiceModel;

namespace MagicEightBallServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Console Based WCF Host ****");
            using (ServiceHost serviceHost = new ServiceHost(typeof(MagicEightBallService))) 
            {
                //Open the host and start listening to incoming messages
                serviceHost.Open();

                //Keep the service running until the Enter key is pressed.
                Console.WriteLine("The service is ready.");
                Console.WriteLine("Press the Enter key to terminate service.");
                Console.ReadLine();
            }
        }
    }
}
