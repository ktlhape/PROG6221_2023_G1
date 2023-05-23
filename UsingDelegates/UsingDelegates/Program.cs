using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace UsingDelegates
{
    internal class Program
    {
        delegate bool FilterDelegate(int x);
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 3,76,35,-13,-5,18,-34,91,15,20};

            Display(numbers,IsEven,"Even");
            Display(numbers, IsOdd,"Odd");
            Display(numbers, IsPositive,"Positive");
            Display(numbers, IsNegative,"Negative");
            Display(numbers, IsMultipleOfThree, "Multiple of Three");
            Console.WriteLine("+++++++++++++++++++");
           
        }

        static bool IsPositive(int x)
        {
            return x >= 0;
        }
        static bool IsNegative(int x)
        {
            return x < 0;
        }
        static bool IsEven(int x)
        {
            return x % 2 == 0;
        }

        static bool IsOdd(int x)
        {
            return x % 2 != 0;
        }
        static bool IsMultipleOfThree(int x)
        {
            return x % 3 == 0;
        }
        static void Display(int[] ar, FilterDelegate filter, string title)
        {
            Console.WriteLine($"====={title}=====");
            foreach (int item in ar)
            {
                if (filter(item))
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
