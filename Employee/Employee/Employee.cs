using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public string[] Skills { get; set; }
        public int NumOfSkills { get; set; }

        public Employee(string name, double salary, int numSkills)
        {
            Name = name;
            Salary = salary;
            NumOfSkills = numSkills;
            Skills = new string[NumOfSkills];
        }
    }
}
