using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExercise
{
    internal class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public double Salary { get; set; }

        public int Skills { get; set; }

        public Employee(string name, string surname, double salary, int skills)
        {
            Name = name;
            Surname = surname;
            Salary = salary;
            Skills = skills;
        }
    }
}
