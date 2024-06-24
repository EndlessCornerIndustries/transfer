using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transfer.Models
{
    public interface IFamily
    {

    }

    public class Family : IFamily
    {

        private List<Person> _adults;
        private List<Person> _dependents;
        private DateTime _calendar;

        public Family(List<Person> adults, List<Person> dependents) { 
        
        }

        public void UpdateFamily()
        {
            foreach (var adult in _adults)
            {
                adult.IncreaseAge();
            }

            foreach (var dependent in _dependents)
            {
                dependent.IncreaseAge();
                // once conditions are met, move child out into family of 1
                if (dependent.GetAge() >= 18)
                {
                };
            }
        }
    }
}
