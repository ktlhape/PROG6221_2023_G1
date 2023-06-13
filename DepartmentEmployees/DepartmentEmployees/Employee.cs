using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentEmployees
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public double Salary { get; set; }
        public List<Employee> lsEmployees = new List<Employee>();
        public string Gender { get; set; } //Radio buttons
        public bool IsMarried { get; set; } //Checkbox 
        public Employee(){}
        public Employee(int employeeID, string firstname, string lastname, double salary)
        {
            EmployeeID = employeeID;
            Firstname = firstname;
            Lastname = lastname;
            Salary = salary;
        }
        public void AddEmployee()
        {
            lsEmployees.Add(this);
        }

        public Employee GetEmployee(int id)
        {
            Employee em = new Employee();
            foreach (Employee item in lsEmployees)
            {
                if (item.EmployeeID == id)
                {
                    em = item;
                }
            }
            return em;  
        }

        public string AllEmployees()
        {
            string strEmployees = "";
            foreach (Employee item in lsEmployees)
            {
                strEmployees += item.Details() + "\n";
               
            }
            return strEmployees;
        }


        public string Details() =>
        
        $"({EmployeeID}): {Firstname} {Lastname} - {Salary.ToString("C2")}";
        
    }
}
