using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    internal class Program
    {
        public delegate void DisplayDelegate(string text);
        public delegate int CountDelegate(string text);
        static void Main(string[] args)
        {
            #region
            /*Expression Lambda
             * (input parameters) => expression
             * 
             * statement lambda
             * (input parameters) =>{
             *      series of statements
             * }
             
             */
            #endregion

            DisplayDelegate myDelegate;
            myDelegate = delegate (string message)
        {
            Console.WriteLine(message);
        };

            //lambda statement
            myDelegate = (m) =>
            {
                string name = "";

                Console.WriteLine(m + " " + name);
            };

            //lambda expression

            myDelegate = (text) => Console.WriteLine(text);

            myDelegate("Hello World");
            CountDelegate countDel;

            //anonymous
            countDel = delegate (string msg)
        {
            return msg.Length;
        };

            //lambda statement
            countDel = (str) =>
            {
                return str.Length;
            };
            //expression lambda

            countDel = (str) => str.Length;
            Console.WriteLine(countDel("Hello World"));
        }
        static void Display(string message)
        {
            Console.WriteLine(message);
        }
        static int Count(string msg)
        {
            return msg.Length;
        }
    }
}
