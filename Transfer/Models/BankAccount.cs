
namespace Transfer.Models
{
    public class BankAccount
    {
        public Person _accountHolder { get; set; }
        private string _accountType { get; set; }
        private double _amount { get; set; }

        public BankAccount(Person accountHolder, string accountType)
        {
            _amount = 0;
        }

        public void Deposit(int depositAmount)
        {
            _amount += depositAmount;
        }

        public void Withdraw(int withdrawAmount)
        {
            _amount -= withdrawAmount;
        }

        public void UpdateAccount()
        {
            if (_accountType == "Savings")
            {
                // apply interest rate here
            }
        }
    }
}
