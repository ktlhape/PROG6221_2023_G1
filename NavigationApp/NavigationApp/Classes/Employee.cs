using NavigationApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigationApp
{
    public class Employee
    {

        public int EmployeeID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();

        public Employee() { }
        public Employee(int employeeID, string firstname, string lastname, string phone, string email)
        {
            EmployeeID = employeeID;
            Firstname = firstname;
            Lastname = lastname;
            Phone = phone;
            Email = email;
        }

        /*Create a method that will return an employee
         * of a matching employee id, pass the employee id as 
         * a parameter*/

        public Employee GetEmployee(int id)
        {
            Employee em = new Employee();

            foreach (Employee emp in Employees)
            {
                if (emp.EmployeeID == id)
                {
                    em = emp;
                }
            }
            return em;
        }

    }
}
