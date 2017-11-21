using System.ServiceModel;

namespace MagicEightBallServiceLib
{
    [ServiceContract(Namespace = "http://MyCompany.com")]
    public interface IEightBall
    {
        //Ask a question, recieve an answer!
        [OperationContract]
        string ObtainAnswertoQuestion(string userQuestion);
    }
}