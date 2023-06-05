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
        List<Employee> lsEmployees = new List<Employee>();
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
            if (txtEmpID.Text.Length < 1)
            {
                MessageBox.Show($"Please enter Employee ID");
                txtEmpID.Focus();
            }
            else
            {
                empID = Convert.ToInt32(txtEmpID.Text);
            }
            
           
            string firstname = txtFirstname.Text;
            string lastname = txtLastname.Text;
            double salary = Convert.ToDouble(txtSalary.Text);

            Employee em = null;

            if (txtFirstname.Text.Length > 1)
            {
                em = new Employee(empID, firstname, lastname, salary);
                    lsEmployees.Add(em);
                    lstDisplay.Items.Add(em.Details());

                    MessageBox.Show($"{em.Firstname} {em.Lastname} has been added");
                    Clear();
              
            }
            else
            {
                MessageBox.Show($"Error - Unable to add employee");
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
    }
}
