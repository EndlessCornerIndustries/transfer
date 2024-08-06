using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transfer.Models
{
    public class GoodService
    {
        private double _toxicity;
        private double _price;
        private DateTime _created;

        public GoodService(double price, double toxicity) { 
            _price = price;
            _toxicity = toxicity;
            _created = DateTime.Now;
        }

        public double GetPrice()
        {
            return _price;
        }
    }
}
