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

namespace MyCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            double num1, num2;

            num1 = Convert.ToDouble(txtNumber1.Text);
            num2 = Convert.ToDouble(txtNumber2.Text);

            double sum = Sum(num1, num2);
            double product = Product(num1, num2);
            lblResults.Content = $"Sum: {sum.ToString()}\n" +
                $"Product: {product.ToString()}";


        }
        public double Sum(double x, double y) => x + y;
        public double Product(double x, double y) => x * y;


     
    }
}
