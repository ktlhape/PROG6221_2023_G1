using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numbers2 = { 6,7,1,18,10,12};
            string[] names = { "Kev", "Kabelo", "John", "Steve" };

            //calculate the sum of all even numbers
            int sum = 0;
            for (int i = 0; i < numbers2.Length; i++)
            {
                if (numbers2[i] % 2 == 0)
                {
                    sum += numbers2[i];
                }
            }
            //{ 6,7,1,18,10,12}
            int highest = numbers2[0];
            for (int i = 1; i < numbers2.Length; i++)
            {
                if (numbers2[i] > highest)
                {
                    highest = numbers2[i];
                }
            }

            int shortLength = names[0].Length;
            string shortName = "None";
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].Length <= shortLength)
                {
                    shortLength = names[i].Length;
                    shortName = names[i];
                }
            }

            Console.WriteLine($"Sum: {sum}");
            Console.Read();

        }
    }
}
