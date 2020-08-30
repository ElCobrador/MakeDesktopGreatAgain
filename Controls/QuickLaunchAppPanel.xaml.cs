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
    /// Interaction logic for QuickLaunchAppPanel.xaml
    /// </summary>
    public partial class QuickLaunchAppPanel : UserControl
    {
        public QuickLaunchAppPanel()
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
    }
}
