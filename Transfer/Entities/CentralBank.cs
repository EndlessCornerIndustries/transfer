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

/*

using System;

public class InterestRateSimulator
{
    private Random random;
    private double currentRate;

    public InterestRateSimulator(double initialRate)
    {
        random = new Random();
        currentRate = initialRate;
    }

    public double NextRate()
    {
        // Simple random walk model: small random changes
        double change = (random.NextDouble() - 0.5) * 0.5; // Change between -0.25 and 0.25
        currentRate += change;

        // Ensuring interest rates stay within a realistic range (0 to 20% for example)
        if (currentRate < 0) currentRate = 0;
        if (currentRate > 20) currentRate = 20;

        return currentRate;
    }

    public static void Main()
    {
        InterestRateSimulator simulator = new InterestRateSimulator(5.0); // Starting rate of 5%

        for (int i = 0; i < 10; i++)
        {
            double newRate = simulator.NextRate();
            Console.WriteLine($"New interest rate: {newRate:F2}%");
        }
    }
}



using System;

public class AR1InterestRateSimulator
{
    private Random random;
    private double currentRate;
    private double alpha;
    private double beta;

    public AR1InterestRateSimulator(double initialRate, double alpha, double beta)
    {
        random = new Random();
        currentRate = initialRate;
        this.alpha = alpha; // Persistence parameter
        this.beta = beta;   // Volatility parameter
    }

    public double NextRate()
    {
        // AR(1) model: new rate = alpha * old rate + random noise
        double noise = beta * (random.NextDouble() - 0.5);
        currentRate = alpha * currentRate + noise;

        // Ensuring interest rates stay within a realistic range (0 to 20% for example)
        if (currentRate < 0) currentRate = 0;
        if (currentRate > 20) currentRate = 20;

        return currentRate;
    }

    public static void Main()
    {
        AR1InterestRateSimulator simulator = new AR1InterestRateSimulator(5.0, 0.9, 0.5); // Starting rate of 5%, alpha = 0.9, beta = 0.5

        for (int i = 0; i < 10; i++)
        {
            double newRate = simulator.NextRate();
            Console.WriteLine($"New interest rate: {newRate:F2}%");
        }
    }
}























using System;

public class PolicyBasedInterestRateSimulator
{
    private Random random;
    private double currentRate;

    public PolicyBasedInterestRateSimulator(double initialRate)
    {
        random = new Random();
        currentRate = initialRate;
    }

    public double NextRate(double inflation, double unemployment)
    {
        // Taylor Rule or similar policy-based rule:
        // Rate = neutral rate + 0.5 * (inflation gap) + 0.5 * (unemployment gap)
        double neutralRate = 2.0;
        double inflationTarget = 2.0;
        double naturalUnemploymentRate = 5.0;

        double inflationGap = inflation - inflationTarget;
        double unemploymentGap = naturalUnemploymentRate - unemployment;

        currentRate = neutralRate + 0.5 * inflationGap + 0.5 * unemploymentGap;

        // Ensuring interest rates stay within a realistic range (0 to 20% for example)
        if (currentRate < 0) currentRate = 0;
        if (currentRate > 20) currentRate = 20;

        return currentRate;
    }

    public static void Main()
    {
        PolicyBasedInterestRateSimulator simulator = new PolicyBasedInterestRateSimulator(5.0); // Starting rate of 5%

        // Example inflation and unemployment data
        double[] inflationData = { 2.1, 2.3, 2.0, 1.8, 2.5 };
        double[] unemploymentData = { 5.2, 5.0, 4.9, 5.1, 5.3 };

        for (int i = 0; i < inflationData.Length; i++)
        {
            double newRate = simulator.NextRate(inflationData[i], unemploymentData[i]);
            Console.WriteLine($"New interest rate: {newRate:F2}%");
        }
    }
}
 */