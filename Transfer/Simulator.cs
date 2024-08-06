using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transfer.Models;

namespace Transfer
{
    public class Simulator
    {
        private SimulationTimer _timer;

        //private List<Family> _families;
        //private List<Business> _businesses;
        //private List<Government> _governments;
        //private CentralBank _centralBank;
        //private List<StockExchange> _stockExchanges;

        public Simulator() {
            _timer = new SimulationTimer(new DateTime(1900, 01, 01));
            /*
            _centralBank = new CentralBank();

            _stockExchanges = new List<StockExchange>() {
                new StockExchange()
            };

            SetupFamilies();
            SetupBusinesses();
            */
        }

        public void Run()
        {
            /*
            int maxIterations = 100;

            int iterations = 0;

            while (iterations < maxIterations)
            {
                _timer.IterateDays();
                iterations++;

                UpdateFamilies();
                UpdateBusinesses();
            }*/
        }
        /*
        public void SetupFamilies()
        {
            _families = new List<Family>()
            {
                new Family(new List<Person>(), new List<Person>()),
            };
        }

        public void SetupBusinesses()
        {
            _businesses = new List<Business> {
                new Business("")
            };
        }

        private void UpdateFamilies()
        {
            foreach(var family in _families)
            {
                family.UpdateFamily();
            }
        }

        private void UpdateBusinesses()
        {
            foreach(var business in _businesses)
            {
                business.up
            }
        }*/
    }
}
