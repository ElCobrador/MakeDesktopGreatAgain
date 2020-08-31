using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MakeDesktopGreatAgain.Controls
{
    class LaunchApplicationBtn : UserControl
    {

        public Core.UserApplication UserApplication { get; set; }
        public Thickness Thickness { get; set; }

        public LaunchApplicationBtn()
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close_App();
        }

        private static void Close_App()
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            var border = new Border();
            border.Padding = Thickness;


            var button = new DefaultButton();
            this.Height = this.ActualWidth;
            button.Click += Button_Click;
            button.Content = UserApplication.ApplicationName;

            border.Child = button;
            this.Content = border;
        }
    }
}
