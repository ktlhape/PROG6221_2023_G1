using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double num1, num2, quotient;
                num1 = 5;
                num2 = 0;

                quotient = Divide(num1, num2);
                Console.WriteLine($"The quotient of {num1} and {num2} is {Math.Round(quotient, 2)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
      
           
            Console.Read();
        }
         static double Divide(double x, double y)
        {
            if (y == 0)
            {
                throw new Exception("The second number cannot be Zero");
            }
            return x / y;
        }

    }
}
