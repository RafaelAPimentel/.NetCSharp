using MagicEightBallServiceClient.ServiceReference1;
using System;


namespace MagicEightBallServiceClient
{
    class Program
    {
        static void Main(string[] args)
        {
           
            using (EightBallClient ball = new EightBallClient())
            {
                Console.WriteLine("***** Ask the Magic 8 Ball*****\n");
                string question = Console.ReadLine();
                string answer = ball.ObtainAnswertoQuestion(question);
                Console.WriteLine($"8-Ball says: {answer}");
            }
            Console.ReadLine();
        }
    }
}
