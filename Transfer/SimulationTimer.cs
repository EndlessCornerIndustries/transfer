using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transfer
{
    public class SimulationTimer
    {
        private DateTime simulationDate;

        public SimulationTimer(DateTime startDate)
        {
            simulationDate = startDate;
        }

        public void IterateDays()
        {
            simulationDate.AddDays(1);
        }

        public DateTime GetSimulationDateTime()
        {
            return simulationDate;
        }
    }
}
