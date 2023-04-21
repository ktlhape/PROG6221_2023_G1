using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Employee
{
    internal class Program
    {
        static int numOfEm, numSkills;
        static string name = "", skill = "";
        static double salary = 0;
        static Employee[] employees;
        static Employee em;
        static void Main(string[] args)
        {
            AddEmployee();
            Console.WriteLine("=============OUTPUT================");
            Display();
           
            Console.Read();
        }

        private static void Display()
        {
            foreach (Employee em in employees)
            {
                Console.WriteLine($"{em.Name} - {em.Salary}");
                Console.WriteLine("=======Skills======");
                foreach (string sk in em.Skills)
                {
                    Console.WriteLine(sk);
                }
                Console.WriteLine();
            }
        }

        private static void AddEmployee()
        {
            Console.Write("How many employees:");
            numOfEm = Convert.ToInt32(Console.ReadLine());

            employees = new Employee[numOfEm];

            for (int i = 0; i < employees.Length; i++)
            {
                Console.Write($"Enter name for employee {i + 1}: ");
                name = Console.ReadLine();
                Console.Write($"Enter Salary for employee {i + 1}: ");
                salary = Convert.ToDouble(Console.ReadLine());
                Console.Write($"Enter Number of skills for employee {i + 1}: ");
                numSkills = Convert.ToInt32(Console.ReadLine());

                em = new Employee(name, salary, numSkills);

                for (int j = 0; j < em.Skills.Length; j++)
                {
                    Console.Write($"Enter Skill {j + 1}: ");
                    skill = Console.ReadLine();
                    em.Skills[j] = skill;
                }
                employees[i] = em;
            }

        }
    }
}
