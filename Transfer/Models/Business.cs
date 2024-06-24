using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transfer.Models
{
    public interface IBusiness
    {

    }
    public class Business : IBusiness
    {
        private List<Person> _employees;
        private List<Business> _businessCustomers;
        private List<Person> _individualCustomers;
        private List<BankAccount> _bankAccounts;

        private DateTime _calendar;
        private string _name;
        public Business(string name) { 
            _name = name;
        }

        public void EmployPerson(Person person)
        {
            _employees.Add(person);
        }

        public void FirePerson(Person person)
        {
            _employees.Remove(person);
        }

        public void UpdateBusiness()
        {
            // pay employees
            foreach (var employee in _employees)
            {

            }
        }
    }
}
