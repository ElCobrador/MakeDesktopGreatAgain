using MakeDesktopGreatAgain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MakeDesktopGreatAgain.Controls
{
    /// <summary>
    /// Interaction logic for LaunchApplicationButton.xaml
    /// </summary>
    public partial class LaunchApplicationButton : UserControl
    {
        public UserApplication UserApplication { get; set; }
        public Thickness Thickness { get; set; }

        public LaunchApplicationButton()
        {
            InitializeComponent();
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
