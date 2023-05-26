using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsExcercise
{
    //Subscriber to the product class
    internal class Customer
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        private Product product;
        public Customer(Product myProduct)
        {
            this.product = myProduct;
            this.product.OnPriceChanged += Product_OnPriceChanged;
        }

        private void Product_OnPriceChanged(object sender, double newPrice)
        {
            Product pr = (Product)sender;
            Console.WriteLine($"Dear {this.ToString()}, " +
                $"The price for {pr.Desc} has changed to {newPrice.ToString("C2")}");
        }
        public override string ToString()
        {
            return $"{Firstname} {Lastname}";
        }
    }
}
