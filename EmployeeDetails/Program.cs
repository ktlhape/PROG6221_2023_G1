using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EmployeeDetails
{
    internal class Program
    {
        //Declare
        static string name, surname, staffNumber, idNumber;
        static double salary;
        static char employment;
        static void Main(string[] args)
        {
            //Assign
            Console.Write("Staff No: ");
            staffNumber = Console.ReadLine();
            Console.Write("Name: ");
            name = Console.ReadLine();
            Console.Write("Surname: ");
            surname = Console.ReadLine();
            Console.Write("Salary: ");
            salary = Convert.ToDouble(Console.ReadLine());
            Console.Write("ID Number: ");
            idNumber = Console.ReadLine();
            Console.Write("Employment Type (F, P, C): ");
            employment = Convert.ToChar(Console.ReadLine());

            //Display
            Console.WriteLine("============BEFORE CHANGES==================");
            DisplayDetails();
            //Changes
            surname = surname.ToUpper();
            name = name.Replace("a", "uoa");
            name = name.Insert(0, "#");
            //salary = salary + (salary * 0.05);
            salary += (salary * 0.05);

            Console.WriteLine("============AFTER CHANGES==================");
            DisplayDetails();
            Console.WriteLine("ID Length: " + idNumber.Length);

            Console.Read();
        }

        static void DisplayDetails()
        {
            Console.WriteLine("Staff No: " + staffNumber);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Surname: " + surname);
            Console.WriteLine("Salary: " + salary);
            Console.WriteLine("ID Number: " + idNumber);
            Console.WriteLine("Employment Type: " + employment);
        }

        static int GetDay()
        {   //9805235449081
            return Convert.ToInt32(idNumber.Substring(4, 2));
        }
        static string GetMonth()
        {
            string strMonth = "NONE";
            int month = Convert.ToInt32(idNumber.Substring(2, 2));
            if (month == 1)
            {
                strMonth = "JAN";
            }
            else if (month == 2) { strMonth = "FEB"; }
            else if (month == 3) { strMonth = "MAR"; }
            else if (month == 4) { strMonth = "APR"; }
            else if (month == 5) { strMonth = "MAY"; }
            else if (month == 6) { strMonth = "JUN"; }
            else if (month == 7) { strMonth = "JUL"; }
            else if (month == 8) { strMonth = "AUG"; }
            else if (month == 9) { strMonth = "SEP"; }
            else if (month == 10) { strMonth = "OCT"; }
            else if (month == 11) { strMonth = "NOV"; }
            else if (month == 12) { strMonth = "DEC"; }

            return strMonth;

        }

        static string GetYear()
        {

            string strYear = idNumber.Substring(0, 2);
            return "19" + strYear;
        }
    }
}
