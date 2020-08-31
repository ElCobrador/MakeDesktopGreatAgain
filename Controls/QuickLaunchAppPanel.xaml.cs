using MakeDesktopGreatAgain.Core;
using MakeDesktopGreatAgain.Utils;
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
        private static int maxApplicationsPerColumn = 2;

        public QuickLaunchAppPanel()
        {
            InitializeComponent();
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            updateGrid();
        }

        private void updateGrid()
        {
            Grid grid = new Grid();

            grid.RowDefinitions.Add(new RowDefinition());

            for (int i = 0; i < maxApplicationsPerColumn; i++)
            {
                grid.ColumnDefinitions.Add(new ColumnDefinition());
            }

            grid.VerticalAlignment = VerticalAlignment.Top;

            GridPosition currentPosition = new GridPosition(0, 0);
            foreach (var application in GetApplicationButtons())
            {
                AddApplicationbutton(grid, currentPosition, application);
                currentPosition = MoveGridPositionToNextAvailablePlace(grid, currentPosition);
            }

            this.Content = grid;
        }

        private void AddApplicationbutton(Grid grid, GridPosition currentPosition, LaunchApplicationButton application)
        {
            Grid.SetRow(application, currentPosition.Y);
            Grid.SetColumn(application, currentPosition.X);
            grid.Children.Add(application);
        }

        private static GridPosition MoveGridPositionToNextAvailablePlace(Grid grid, GridPosition currentPosition)
        {
            currentPosition.X++;

            if (currentPosition.X >= maxApplicationsPerColumn)
            {
                currentPosition.X = 0;
                currentPosition.Y++;
                grid.RowDefinitions.Add(new RowDefinition());
            }

            return currentPosition;
        }

        private List<LaunchApplicationButton> GetApplicationButtons()
        {
            var userApplicationManager = new UserApplicationsManager();
            var padding = this.ActualWidth * 0.05;

            var applicationsLaunchers = new List<LaunchApplicationButton>();

            foreach (var application in userApplicationManager.GetUserApplications())
            {
                var applicationButton = new LaunchApplicationButton() { UserApplication = application, Thickness = new Thickness(padding) };
                applicationsLaunchers.Add(applicationButton);
            }

            return applicationsLaunchers;
        }
    }
}
