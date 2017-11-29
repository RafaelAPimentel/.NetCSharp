using System.ServiceProcess;
using System.ServiceModel;
using MathServiceLibrary;
using System;

namespace MathWinServiceHost
{
    public partial class MathWinService : ServiceBase
    {
        //A member variable of type ServiceHost
        private ServiceHost _myHost;

        public MathWinService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            //Just to be really safe
            if (_myHost != null)
            {
                _myHost.Close();
                _myHost = null;
            }

            //Create the host Ns specify a URL for an HTTP binding.
            _myHost = new ServiceHost(typeof(MathService),
                new Uri("http://localhost:8080/MathServiceLibrary"));

            //The ABC's in code!
            _myHost.AddDefaultEndpoints();

            //Open the host
            _myHost.Open();
        }

        protected override void OnStop()
        {
            //Shut down the host
            _myHost?.Close();
        }
    }
}
