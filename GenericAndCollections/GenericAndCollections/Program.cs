using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAndCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arNumbers = new int[] { 4, 8, 12, -3, 10 };
            string[] arNames = new string[] { "John", "Kelvin", "Kabelo", "Steve", "Jassica" };
            double[] arPrices = new double[] { 20.56, 19.50, 45.99, 105.99, 15.95 };

            Student[] arStudents = new Student[] { 
                new Student(1,"Kabelo","Tlhape",71),
                new Student(2,"Roger","Federer",68),
                new Student(3,"Jessica","Parks",83),
                new Student(4,"David","Jones",65),
                new Student(5,"Caroline","Smith",55),
            };


            DisplayElements<int>(arNumbers, "Numbers");
            DisplayElements<string>(arNames, "Names");
            DisplayElements<double>(arPrices, "Prices");
            DisplayElements<Student>(arStudents, "Students");

            Console.Read();
        }
        static void DisplayElements<T>(T[] ar, string title)
        {
            Console.WriteLine($"====={title}=====");
            foreach (T item in ar)
            {
                Console.WriteLine(item.ToString());
            }
        }

    }
}
