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

        public Employee(){}
        public Employee(int employeeID, string firstname, string lastname, double salary)
        {
            EmployeeID = employeeID;
            Firstname = firstname;
            Lastname = lastname;
            Salary = salary;
        }

        public string Details()
        {
            return $"({EmployeeID}): {Firstname} {Lastname} - {Salary.ToString("C2")}";
        }
    }
}
