using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDetails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string stNo, name, surname;
                int numModules;
                Console.Write("Enter Student No: ");
                stNo = Console.ReadLine();
                Console.Write("Enter Name: ");
                name = Console.ReadLine();
                Console.Write("Enter Surname: ");
                surname = Console.ReadLine();
                Console.Write("Enter Number of Modules: ");
                numModules = Convert.ToInt32(Console.ReadLine());

                Student st1 = new Student(stNo, name, surname, numModules);
                //3
                for (int i = 0; i < numModules; i++)
                {
                    Console.Write($"Enter module {(i + 1)}: ");
                    st1.Modules[i] = Console.ReadLine();
                }

                Console.WriteLine("==========OUTPUT==============");
                Console.WriteLine(st1.Display());
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            
            Console.Read();
        }
    }
}
