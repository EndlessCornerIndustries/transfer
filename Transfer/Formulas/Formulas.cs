using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transfer.Formulas
{
    public static class Formulas
    {
        public static double CalculateGdp(double consumption, double investment, double governmentSpending, double exports, double imports)
        {
            return consumption + investment + governmentSpending + (exports - imports);
        }

        public static double CalculateTaxes()
        {
            return 0;
        }

        public static double CalculateFines()
        {
            return 0; 
        }
    }
}
