using System;
using System.Windows;

namespace WpfAppAllCode
{
    //In this first example, you ar defining a single class type to
    //represent the application itself and the main windows
    class Program : Application
    {
        [STAThread]
        static void Main()
        {
            Program app = new Program();
            app.Startup += new StartupEventHandler(AppStartUp);
            app.Exit += new ExitEventHandler(AppExit);
            app.Run(); //Fires the Startup event
        }

        static void AppExit(object sender, ExitEventArgs e)
        {
            MessageBox.Show("App has exited");
        }

        static void AppStartUp(object sender, StartupEventArgs e)
        {
            //Check the incoming command-line arguments and see if they
            //specified a flag for /GODMODE
            Application.Current.Properties["GODMODE"] = false;
            foreach (string arg in e.Args)
            {
                if (arg.ToLower() == "/godmode")
                {
                    Application.Current.Properties["GODMODE"] = true;
                    break;
                }
            }
            //Create a Window object and set some basic properties
            var wnd = new MainWindow("My better WPF APP!", 200, 300);
            wnd.Show();
        }
    }
}
