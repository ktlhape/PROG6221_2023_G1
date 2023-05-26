using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsExcercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product myProduct = new Product("COKE12", "Coke Zero", 25.00);
            Customer c = new Customer(myProduct);
            c.Firstname = "Kabelo";
            c.Lastname = "Smith";

            myProduct.Price = 18.50;
            myProduct.Price = 28.50;
            myProduct.Price = 38.50;
            Console.Read();
        }
    }
}
