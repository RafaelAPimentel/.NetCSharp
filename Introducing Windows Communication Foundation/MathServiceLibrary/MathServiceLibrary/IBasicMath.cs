using System.ServiceModel;

namespace MathServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract(Namespace ="http://MyComplany.com")]
    public interface IBasicMath
    {
        [OperationContract]
        int Add(int valueOne, int valueTwo);
    }
}
