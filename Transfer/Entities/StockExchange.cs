using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transfer.Models
{
    public interface IStockExchange
    {

    }

    public class StockExchange : IStockExchange
    {
        public StockExchange() { 
        
        }
    }
}

/*
using System;
using MathNet.Numerics.Distributions;

public class GBMStockPriceSimulator
{
    private double initialPrice;
    private double mu;
    private double sigma;
    private double deltaT;
    private int steps;
    private Random random;

    public GBMStockPriceSimulator(double initialPrice, double mu, double sigma, double deltaT, int steps)
    {
        this.initialPrice = initialPrice;
        this.mu = mu;
        this.sigma = sigma;
        this.deltaT = deltaT;
        this.steps = steps;
        this.random = new Random();
    }

    public double[] Simulate()
    {
        double[] prices = new double[steps];
        prices[0] = initialPrice;

        for (int i = 1; i < steps; i++)
        {
            double Z = Normal.Sample(random, 0, 1); // Standard normal random variable
            prices[i] = prices[i - 1] * Math.Exp((mu - 0.5 * sigma * sigma) * deltaT + sigma * Math.Sqrt(deltaT) * Z);
        }

        return prices;
    }

    public static void Main(string[] args)
    {
        // Parameters
        double initialPrice = 100.0; // Initial stock price
        double mu = 0.1; // Drift rate (10%)
        double sigma = 0.2; // Volatility (20%)
        double deltaT = 1.0 / 252.0; // Daily time step (assuming 252 trading days in a year)
        int steps = 252; // Number of steps (one year of trading days)

        // Create simulator
        var simulator = new GBMStockPriceSimulator(initialPrice, mu, sigma, deltaT, steps);

        // Run simulation
        double[] prices = simulator.Simulate();

        // Output simulated prices
        for (int i = 0; i < prices.Length; i++)
        {
            Console.WriteLine($"Day {i + 1}: {prices[i]:F2}");
        }
    }
}
 */