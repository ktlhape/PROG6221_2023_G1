using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsExcercise
{
    internal class Product
    {
        public event EventHandler<double> OnPriceChanged;
        public string Code { get; set; }
        public string Desc { get; set; }
        private double _price;

        public double Price
        {
            get { return _price; }
            set {
                if (_price != value)
                {
                    _price = value;
                    this.OnPriceChanged?.Invoke(this, this._price);
                }
             }
        }

        public Product(string code, string desc, double price)
        {
            Code = code;
            Desc = desc;
            _price = price;
        }
    }
}
