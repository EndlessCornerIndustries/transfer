using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transfer.Models
{
    public interface IBank {

    }

    public class Bank : IBank
    {
        private List<BankAccount> _accounts;

        public Bank()
        {

        }
    }
}
