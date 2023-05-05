using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //StudentDictionary();
            //EmployeeDictionary();
            ModulesDictionary();

        }

        private static void ModulesDictionary()
        {
            /*Create a dictionary to strore modules and 
             a list of studednts enrolled for each module*/

            Dictionary<string, List<string>> modules =
                new Dictionary<string, List<string>>();

            //Add items
            modules.Add("PROG2A", new List<string>() { "Kabelo", "Lerato", "James" });
            modules.Add("PROG3A", new List<string>() { "Roger", "Lerato", "Jessica", "James" });
            modules.Add("DATA2A", new List<string>() { "Kabelo", "Lerato" });
            modules.Add("CLVD2A", new List<string>() { "Roger", "Michael", "James","Jessica", "Kabelo" });
            modules.Add("PROG1A", new List<string>() { "Thato", "David", "Kelvin", "Lesego" });

            //Display all items
            foreach (string module in modules.Keys)
            {
                Console.Write(module);
                foreach (string st in modules[module])
                {
                    Console.WriteLine($"\t{st}");
                }
            }
            //Display all students that enrolled for PROG2A
            foreach (string item in modules["PROG2A"].ToList())
            {
                Console.WriteLine(item);
            }
        }

        private static void EmployeeDictionary()
        {
            /*Create a dictionary to store employees with
             their staff numbers and names*/
            Dictionary<int, string> employees =
                new Dictionary<int, string>();

            employees.Add(123, "Roger Federer");
            employees.Add(124, "Serena Williams");
            employees.Add(125, "Jessica Parks");
            employees.Add(126, "Michael Jordan");
            employees.Add(127, "Luka Modric");

            /*Check if the key exist then store the value into 
             the result variable*/
            if (employees.TryGetValue(123,out string result))
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Key not found");
            }


        }

        static void StudentDictionary()
        {
            /*Create a dictionary that will store 
             students ids and names*/
            Dictionary<string, string> students =
                new Dictionary<string, string>();

            //Add items
            students.Add("ST123", "Roger Federer");
            students.Add("ST124", "Serena Williams");
            students.Add("ST125", "Jessica Parks");
            students.Add("ST126", "Michael Jordan");
            students.Add("ST127", "Luka Modric");

            //Access the items
            Console.WriteLine(students["ST124"]);
            //this will override Roger Federer to Kabelo
            students["ST123"] = "Kabelo";

            /*this will create a new record with 123 as a
             * key and Lerato as a value
             */
            students["123"] = "Lerato";

            Console.WriteLine(students["ST123"]);

            //Display all items
            foreach (KeyValuePair<string, string> item in students)
            {
                Console.WriteLine(item);
            }
        }

        static void Results(int x, int y, out double sum, out double product)
        {
            sum = x + y;
            product = x * y;
           
        }
    }
}
