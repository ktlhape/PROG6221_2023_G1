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

            FilterDelegate even = IsEven;
            Display(numbers, even);
            Console.WriteLine("+++++++++++++++++++");
           
        }

        static bool IsEven(int x)
        {
            return x % 2 == 0;
        }

        static bool IsOdd(int x)
        {
            return x % 2 != 0;
        }
        static void Display(List<int> ar, FilterDelegate filter)
        {
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
