using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesIntro
{
    internal class Program
    {
        //declare a public delegate
        public delegate void OutputDelegate(string msg);
        static void Main(string[] args)
        {
            //Print("Hello World");
            //OutputDelegate printDelegate = new OutputDelegate(Print);
            OutputDelegate printDelegate = Print;
            OutputDelegate displayDelegate = Display;

            printDelegate("Hello World - using a Delegate");
            displayDelegate("Kabelo");

            Console.Read();
        }

        static void Print(string message)
        {
            Console.WriteLine(message);
        }
        static void Display(string text)
        {
            Console.WriteLine(text);
        }
        static int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
