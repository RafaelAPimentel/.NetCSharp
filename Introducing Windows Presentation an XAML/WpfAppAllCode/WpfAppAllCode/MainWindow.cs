using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfAppAllCode
{
    class MainWindow : Window
    {
        //Our UI element
        private Button btnExitApp = new Button();

        public MainWindow(string windowTitle,int height, int width)
        {
            //Configure button and set child control
            btnExitApp.Click += new RoutedEventHandler(btnExitApp_Clicked);
            btnExitApp.Content = "Exit Application";
            btnExitApp.Height = 25;
            btnExitApp.Width = 100;

            //Set the content of this window to a single button
            this.Content = btnExitApp;

            //Configure the window
            this.Title = windowTitle;
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            this.Height = height;
            this.Width = width;
            this.Show();
        }

        private void btnExitApp_Clicked(object sender, RoutedEventArgs e)
        {
            //Did user enable /godmode?
            if ((bool)Application.Current.Properties["GODMODE"])
            {
                MessageBox.Show("Cheater");
            }
            //Close the window
            this.Close();
        }
    }
}
