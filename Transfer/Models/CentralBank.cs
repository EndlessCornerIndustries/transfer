using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transfer.Models
{
    public interface ICentralBank
    {

    }

    public class CentralBank : ICentralBank
    {
        public double _interestRate;
        public double _inflation;
        public CentralBank() { 
        
        }

        public double GetInterestRate()
        {
            return _interestRate;
        }

        public void UpdateMonetaryPolicy()
        {
            if (_inflation > 0.02)
            {
                _interestRate += 0.25;
            }
        }

        public void CalculateCPI(List<GoodService> goods)
        {
            var allPrices = goods.Select(x => x.GetPrice()).ToList();
        }
    }
}
