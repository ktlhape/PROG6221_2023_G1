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

namespace DepartmentEmployees
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Employee em = null;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            int empID = 0;
            string firstname;
            string lastname;
            double salary;

            if (txtEmpID.Text.Trim().Length > 1 || txtFirstname.Text.Trim().Length > 1 ||
                txtLastname.Text.Trim().Length > 1 || txtSalary.Text.Trim().Length > 1)
            {
                empID = Convert.ToInt32(txtEmpID.Text);
                firstname = txtFirstname.Text;
                lastname = txtLastname.Text;
                salary = Convert.ToDouble(txtSalary.Text);

                em = new Employee(empID, firstname, lastname, salary);
                em.AddEmployee();
                //lstDisplay.Items.Add(em.Details());
                Clear();
            }
            else
            {
                MessageBox.Show("Please enter all details");
            } 
        }
        public void Clear()
        {
            txtEmpID.Clear();
            txtFirstname.Clear();
            txtLastname.Clear();
            txtSalary.Clear();
            txtEmpID.Focus();
        }

        private void btnDisplay_Click(object sender, RoutedEventArgs e)
        {
            lstDisplay.Items.Add(em.AllEmployees());
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            SearchWindow sw = new SearchWindow();
            sw.ShowDialog();
        }
    }
}
