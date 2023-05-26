using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExercise
{
    internal class Program
    {
        delegate bool IsPromotable(Employee em);
        static void Main(string[] args)
        {
            List<Employee> emList = new List<Employee>() { 
            new Employee("Michael","Jordan",10000,3),
            new Employee("Roger","Federer",18000,2),
            new Employee("John","Smith",15000,5),
            new Employee("Olivia","Stones",20000,3),
            new Employee("Jessica","Parks",19000,2),
            };

            PromoteEmployee(emList, PromoteBySkills);
        }
        static void PromoteEmployee(List<Employee> empList, IsPromotable promotable)
        {
            foreach (Employee em in empList)
            {
                if (promotable(em))
                {
                    Console.WriteLine($"{em.Name} - Promoted");
                }
            }
        }
        static bool PromoteBySalary(Employee em)
        {
            return em.Salary > 15000;
        }
        static bool PromoteBySkills(Employee em)
        {
            return em.Skills > 3;
        }
    }
}
