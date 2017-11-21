using System;

namespace MagicEightBallServiceLib
{
    public class MagicEightBallService : IEightBall
    {
        //Just for display puposes on the host.
        public MagicEightBallService() => Console.WriteLine("The 8-ball awaits your question...");

        public string ObtainAnswertoQuestion(string userQuestion)
        {
            string[] answers = { "Future Uncertain", "Yes", "No", "Hazy", "Ask again later", "Definitely" };

            //Return a random response9*
            return answers[new Random().Next(answers.Length)];
        }
    }
}
