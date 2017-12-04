using MagicEightBallServiceClient.ServiceReference1;
using System;


namespace MagicEightBallServiceClient
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("***** Ask the Magic 8 Ball*****\n");

            //You can enter into the client constructor which binding 
            //you want to use when instantiating the class
            using (EightBallClient ball = new EightBallClient("BasicHttpBinding_IEightBall"))
            {
                Console.WriteLine("Your question: ");
                string question = Console.ReadLine();
                string answer = ball.ObtainAnswertoQuestion(question);
                Console.WriteLine($"8-Ball says: {answer}");
            }
            Console.ReadLine();
        }
    }
}
