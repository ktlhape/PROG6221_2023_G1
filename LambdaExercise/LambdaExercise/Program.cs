using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExercise
{
    internal class Program
    {
        public delegate bool Filter(int b);
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 5,74,1,30,-17,12,-14,50,-15};
            //Display(numbers, "Even",(x) => x % 2 == 0);
            //Display(numbers, "Odd", IsOdd);
            //Display(numbers, "Positive", Ispositive);
            //Display(numbers, "Negative", IsNegative);


            List<int> positiveList = new List<int>();

            positiveList = numbers.Where(x => x % 2 == 0).ToList();

            foreach (int p in positiveList)
            {
                Console.WriteLine(p);
            }
        }

        public static void Display(List<int> ls, string title,Filter filter)
        {
            Console.WriteLine($"====={title}=====");
            foreach (int num in ls)
            {
                if (filter(num))
                {
                    Console.WriteLine(num);
                }
            }
        }
        //static bool IsEven(int x) => x % 2 == 0;
        static bool IsOdd(int x) => x % 2 != 0;
        static bool Ispositive(int x) => x >= 0;
        static bool IsNegative(int x) => x < 0;
    }
}
