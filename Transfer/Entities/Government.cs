using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transfer.Models
{
    public interface IGovernment
    {

    }

    public class Government : IGovernment
    {
        private List<Policy> _policies;
        private string _name;
        private string _level;
        private double revenue;

        public Government(string name, string level)
        {
            _name = name;
            _level = level;
        }

        public void UpdatePolicies()
        {
            /*_policies.Add(new Policy()
            {
                
            });*/
        }
    }
}
