using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transfer.Entities
{
    internal class TradedGood
    {
    }
}

/*
using System;
using MathNet.Numerics.Distributions;
using System.Collections.Generic;

public class Commodity
{
    public string Name { get; set; }
    public double InitialPrice { get; set; }
    public double CurrentPrice { get; set; }
    public double Volatility { get; set; } // σ
    public double Drift { get; set; } // μ
    public double Supply { get; set; }
    public double Demand { get; set; }
    public double ProductionCost { get; set; }
    public double TariffRate { get; set; }
    public double Subsidy { get; set; }
    public double ExchangeRate { get; set; }

    public Commodity(string name, double initialPrice, double volatility, double drift)
    {
        Name = name;
        InitialPrice = initialPrice;
        CurrentPrice = initialPrice;
        Volatility = volatility;
        Drift = drift;
        Supply = 100;
        Demand = 100;
        ProductionCost = 50;
        TariffRate = 0.1;
        Subsidy = 10;
        ExchangeRate = 1.0;
    }

    public void UpdatePrice(double timeStep)
    {
        double Z = Normal.Sample(0, 1);
        CurrentPrice *= Math.Exp((Drift - 0.5 * Volatility * Volatility) * timeStep + Volatility * Math.Sqrt(timeStep) * Z);
    }

    public void AdjustSupplyDemand()
    {
        // Simulate changes in supply and demand
        Supply += Normal.Sample(0, 10);
        Demand += Normal.Sample(0, 10);
        if (Supply < 0) Supply = 0;
        if (Demand < 0) Demand = 0;
    }

    public void ApplyPolicyChanges()
    {
        // Apply tariffs and subsidies
        CurrentPrice += TariffRate * CurrentPrice - Subsidy;
    }

    public void ApplyExchangeRateEffect()
    {
        // Apply exchange rate effect on price
        CurrentPrice *= ExchangeRate;
    }

    public override string ToString()
    {
        return $"{Name}: {CurrentPrice:F2} (Supply: {Supply}, Demand: {Demand})";
    }
}

public class CommoditySimulator
{
    private List<Commodity> commodities;
    private double timeStep;

    public CommoditySimulator(double timeStep)
    {
        commodities = new List<Commodity>();
        this.timeStep = timeStep;
    }

    public void AddCommodity(Commodity commodity)
    {
        commodities.Add(commodity);
    }

    public void RunSimulation(int steps)
    {
        for (int i = 0; i < steps; i++)
        {
            Console.WriteLine($"Step {i + 1}");
            foreach (var commodity in commodities)
            {
                commodity.UpdatePrice(timeStep);
                commodity.AdjustSupplyDemand();
                commodity.ApplyPolicyChanges();
                commodity.ApplyExchangeRateEffect();
                Console.WriteLine(commodity);
            }
            Console.WriteLine();
        }
    }

    public static void Main(string[] args)
    {
        CommoditySimulator simulator = new CommoditySimulator(1.0 / 252.0); // Daily time step

        // Adding some commodities
        simulator.AddCommodity(new Commodity("Gold", 1800, 0.2, 0.05));
        simulator.AddCommodity(new Commodity("Oil", 70, 0.3, 0.02));
        simulator.AddCommodity(new Commodity("Wheat", 5, 0.1, 0.03));

        // Running the simulation for 10 steps
        simulator.RunSimulation(10);
    }
}


















using System;
using System.Collections.Generic;
using MathNet.Numerics.Distributions;

public class Commodity
{
    public string Name { get; set; }
    public double InitialPrice { get; set; }
    public double CurrentPrice { get; set; }
    public double Volatility { get; set; } // σ
    public double Drift { get; set; } // μ
    public double Supply { get; set; }
    public double Demand { get; set; }
    public double ProductionCost { get; set; }
    public double TariffRate { get; set; }
    public double Subsidy { get; set; }
    public double ExchangeRate { get; set; }
    public double InflationRate { get; set; }
    public double InterestRate { get; set; }
    public double GeopoliticalRisk { get; set; }
    public double EnvironmentalImpact { get; set; }
    public double SeasonalEffect { get; set; }

    public Commodity(string name, double initialPrice, double volatility, double drift)
    {
        Name = name;
        InitialPrice = initialPrice;
        CurrentPrice = initialPrice;
        Volatility = volatility;
        Drift = drift;
        Supply = 100;
        Demand = 100;
        ProductionCost = 50;
        TariffRate = 0.1;
        Subsidy = 10;
        ExchangeRate = 1.0;
        InflationRate = 0.02;
        InterestRate = 0.03;
        GeopoliticalRisk = 0.05;
        EnvironmentalImpact = 0.01;
        SeasonalEffect = 0.05;
    }

    public void UpdatePrice(double timeStep)
    {
        double Z = Normal.Sample(0, 1);
        CurrentPrice *= Math.Exp((Drift - 0.5 * Volatility * Volatility) * timeStep + Volatility * Math.Sqrt(timeStep) * Z);
    }

    public void AdjustSupplyDemand()
    {
        // Simulate changes in supply and demand
        Supply += Normal.Sample(0, 10) - EnvironmentalImpact * Supply + SeasonalEffect * Math.Sin(2 * Math.PI * DateTime.Now.DayOfYear / 365);
        Demand += Normal.Sample(0, 10) + InflationRate * Demand - SeasonalEffect * Math.Sin(2 * Math.PI * DateTime.Now.DayOfYear / 365);
        if (Supply < 0) Supply = 0;
        if (Demand < 0) Demand = 0;
    }

    public void ApplyPolicyChanges()
    {
        // Apply tariffs and subsidies
        CurrentPrice += TariffRate * CurrentPrice - Subsidy;
    }

    public void ApplyEconomicFactors()
    {
        // Apply interest and inflation rate effects
        CurrentPrice *= (1 + InflationRate - InterestRate);
    }

    public void ApplyExchangeRateEffect()
    {
        // Apply exchange rate effect on price
        CurrentPrice *= ExchangeRate;
    }

    public void ApplyGeopoliticalRisk()
    {
        // Apply geopolitical risk effect on price
        CurrentPrice *= (1 + GeopoliticalRisk);
    }

    public void ApplyInteractions(List<Commodity> commodities)
    {
        // Example interaction: Oil price affecting transportation costs
        if (Name != "Oil")
        {
            var oil = commodities.Find(c => c.Name == "Oil");
            if (oil != null)
            {
                CurrentPrice += 0.01 * oil.CurrentPrice; // Simplified interaction
            }
        }
    }

    public void Update(double timeStep, List<Commodity> commodities)
    {
        UpdatePrice(timeStep);
        AdjustSupplyDemand();
        ApplyPolicyChanges();
        ApplyEconomicFactors();
        ApplyExchangeRateEffect();
        ApplyGeopoliticalRisk();
        ApplyInteractions(commodities);
    }

    public override string ToString()
    {
        return $"{Name}: {CurrentPrice:F2} (Supply: {Supply}, Demand: {Demand})";
    }
}

public class GeopoliticalEvent
{
    public string Name { get; set; }
    public double ImpactProbability { get; set; }
    public double ImpactMagnitude { get; set; }

    public GeopoliticalEvent(string name, double probability, double magnitude)
    {
        Name = name;
        ImpactProbability = probability;
        ImpactMagnitude = magnitude;
    }

    public void ApplyImpact(List<Commodity> commodities, Random random)
    {
        if (random.NextDouble() < ImpactProbability)
        {
            foreach (var commodity in commodities)
            {
                commodity.GeopoliticalRisk += ImpactMagnitude;
            }
        }
    }
}

public class CommoditySimulator
{
    private List<Commodity> commodities;
    private List<GeopoliticalEvent> geopoliticalEvents;
    private double timeStep;
    private Random random;

    public CommoditySimulator(double timeStep)
    {
        commodities = new List<Commodity>();
        geopoliticalEvents = new List<GeopoliticalEvent>();
        this.timeStep = timeStep;
        random = new Random();
    }

    public void AddCommodity(Commodity commodity)
    {
        commodities.Add(commodity);
    }

    public void AddGeopoliticalEvent(GeopoliticalEvent geopoliticalEvent)
    {
        geopoliticalEvents.Add(geopoliticalEvent);
    }

    public void RunSimulation(int steps)
    {
        for (int i = 0; i < steps; i++)
        {
            Console.WriteLine($"Step {i + 1}");
            foreach (var eventItem in geopoliticalEvents)
            {
                eventItem.ApplyImpact(commodities, random);
            }

            foreach (var commodity in commodities)
            {
                commodity.Update(timeStep, commodities);
                Console.WriteLine(commodity);
            }
            Console.WriteLine();
        }
    }

    public static void Main(string[] args)
    {
        CommoditySimulator simulator = new CommoditySimulator(1.0 / 252.0); // Daily time step

        // Adding some commodities
        simulator.AddCommodity(new Commodity("Gold", 1800, 0.2, 0.05));
        simulator.AddCommodity(new Commodity("Oil", 70, 0.3, 0.02));
        simulator.AddCommodity(new Commodity("Wheat", 5, 0.1, 0.03));

        // Adding some geopolitical events
        simulator.AddGeopoliticalEvent(new GeopoliticalEvent("Middle East Tension", 0.1, 0.02));
        simulator.AddGeopoliticalEvent(new GeopoliticalEvent("Trade War", 0.05, 0.03));

        // Running the simulation for 10 steps
        simulator.RunSimulation(10);
    }
}
 */