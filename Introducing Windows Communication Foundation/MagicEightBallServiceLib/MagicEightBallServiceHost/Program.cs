using System;
using System.ServiceModel;
using MagicEightBallServiceLib;

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
                DisplayhostInfo(serviceHost);
                //Keep the service running until the Enter key is pressed.
                Console.WriteLine("The service is ready.");
                Console.WriteLine("Press the Enter key to terminate service.");
                Console.ReadLine();
            }
        }
        static void DisplayhostInfo(ServiceHost host)
        {
            Console.WriteLine();
            Console.WriteLine("**** Host Info ****");

            foreach (System.ServiceModel.Description.ServiceEndpoint se in host.Description.Endpoints)
            {
                Console.WriteLine($"Address: {se.Address}");
                Console.WriteLine($"Binding: {se.Binding.Name}");
                Console.WriteLine($"Contract: {se.Contract.Name}");
                Console.WriteLine();
            }
            Console.WriteLine("*******************");
        }

    }
}
