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

namespace DataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Employee empHelper = new Employee();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            //Declare
            int empID;
            string firstname, lastname, phone, email;

            //Assign
            empID = Convert.ToInt32(txtEmployeeID.Text);
            firstname = txtFirstname.Text;
            lastname = txtLastname.Text;
            phone = txtPhone.Text;
            email = txtEmail.Text;

            Employee em = new Employee(empID,firstname,lastname,phone,email);
            empHelper.Employees.Add(em);

            ClearForm();
        }

        public void ClearForm()
        {
            txtEmail.Clear();
            txtEmployeeID.Clear();
            txtFirstname.Clear();
            txtLastname.Clear();
            txtPhone.Clear();
            txtEmployeeID.Focus();
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            ClearForm();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            int id;
            id = Convert.ToInt32(txt_EmployeeID.Text);
            Employee myEmployee = empHelper.GetEmployee(id);

            //txt_Firstname.Text = myEmployee.Firstname;
            //txt_Lastname.Text = myEmployee.Lastname;
            //txt_Phone.Text = myEmployee.Phone;
            //txt_Email.Text = myEmployee.Email;

            this.DataContext = myEmployee;
        }
    }
}
