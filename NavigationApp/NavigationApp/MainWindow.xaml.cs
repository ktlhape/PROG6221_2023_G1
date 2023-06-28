using NavigationApp.Views;
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

namespace NavigationApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PgHome homePg = new PgHome();
        PgDisplay displayPg = new PgDisplay();
        PgSearch searchPg = new PgSearch();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            frmContainer.Content = homePg;
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            frmContainer.Content = searchPg;
        }

        private void btnDisplay_Click(object sender, RoutedEventArgs e)
        {
            frmContainer.Content = displayPg;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            frmContainer.Content = homePg;
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            
            if (MessageBox.Show("Do you want to exit?", "Employee App", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                this.Close();
            }
        }
    }
}
