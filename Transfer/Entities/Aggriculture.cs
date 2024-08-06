using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transfer.Entities
{
    internal class Aggriculture
    {
    }
}

/*
using System;
using System.Collections.Generic;

public class BankAccount
{
    public string AccountType { get; set; }
    public double Balance { get; set; }
    public double InterestRate { get; set; }
    public double Fee { get; set; }

    public BankAccount(string accountType, double initialBalance, double interestRate, double fee)
    {
        AccountType = accountType;
        Balance = initialBalance;
        InterestRate = interestRate;
        Fee = fee;
    }

    public void ApplyInterest()
    {
        Balance += Balance * InterestRate;
    }

    public void ApplyFee()
    {
        Balance -= Fee;
        if (Balance < 0) Balance = 0; // Ensure balance doesn't go negative
    }

    public override string ToString()
    {
        return $"{AccountType} Account: Balance = {Balance:F2}, Interest Rate = {InterestRate:P2}, Fee = {Fee:F2}";
    }
}

public class Loan
{
    public double Principal { get; set; }
    public double InterestRate { get; set; }
    public double MonthlyPayment { get; set; }
    public int MonthsRemaining { get; set; }

    public Loan(double principal, double interestRate, double monthlyPayment, int monthsRemaining)
    {
        Principal = principal;
        InterestRate = interestRate;
        MonthlyPayment = monthlyPayment;
        MonthsRemaining = monthsRemaining;
    }

    public void MakePayment()
    {
        Principal -= MonthlyPayment;
        if (Principal < 0) Principal = 0; // Ensure principal doesn't go negative
        MonthsRemaining--;
    }

    public override string ToString()
    {
        return $"Loan: Principal = {Principal:F2}, Interest Rate = {InterestRate:P2}, Monthly Payment = {MonthlyPayment:F2}, Months Remaining = {MonthsRemaining}";
    }
}

public class Investment
{
    public double InvestmentAmount { get; set; }
    public double InterestRate { get; set; }
    public int InvestmentPeriodMonths { get; set; }

    public Investment(double investmentAmount, double interestRate, int investmentPeriodMonths)
    {
        InvestmentAmount = investmentAmount;
        InterestRate = interestRate;
        InvestmentPeriodMonths = investmentPeriodMonths;
    }

    public void ApplyInterest()
    {
        InvestmentAmount += InvestmentAmount * (InterestRate / 12); // Monthly compounding
    }

    public override string ToString()
    {
        return $"Investment: Amount = {InvestmentAmount:F2}, Interest Rate = {InterestRate:P2}, Period = {InvestmentPeriodMonths} months";
    }
}

public class Bank
{
    public string Name { get; set; }
    public double FederalInvestmentRate { get; set; }
    public List<BankAccount> Accounts { get; set; }
    public List<Loan> Loans { get; set; }
    public List<Investment> Investments { get; set; }

    public Bank(string name, double federalInvestmentRate)
    {
        Name = name;
        FederalInvestmentRate = federalInvestmentRate;
        Accounts = new List<BankAccount>();
        Loans = new List<Loan>();
        Investments = new List<Investment>();
    }

    public void AddAccount(BankAccount account)
    {
        Accounts.Add(account);
    }

    public void AddLoan(Loan loan)
    {
        Loans.Add(loan);
    }

    public void AddInvestment(Investment investment)
    {
        Investments.Add(investment);
    }

    public void ApplyFederalRateToInvestments()
    {
        foreach (var investment in Investments)
        {
            investment.InterestRate += FederalInvestmentRate; // Adjust investment rate based on federal rate
        }
    }

    public void Update(double timeStep)
    {
        ApplyFederalRateToInvestments();
        foreach (var account in Accounts)
        {
            account.ApplyInterest();
            account.ApplyFee();
        }
        foreach (var loan in Loans)
        {
            loan.MakePayment();
        }
        foreach (var investment in Investments)
        {
            investment.ApplyInterest();
        }
    }

    public override string ToString()
    {
        string accountsStr = string.Join("\n", Accounts);
        string loansStr = string.Join("\n", Loans);
        string investmentsStr = string.Join("\n", Investments);

        return $"Bank: {Name}\nFederal Investment Rate: {FederalInvestmentRate:P2}\nAccounts:\n{accountsStr}\nLoans:\n{loansStr}\nInvestments:\n{investmentsStr}";
    }
}

public class BankSimulator
{
    private Bank bank;
    private double timeStep;
    private Random random;

    public BankSimulator(Bank bank, double timeStep)
    {
        this.bank = bank;
        this.timeStep = timeStep;
        random = new Random();
    }

    public void RunSimulation(int steps)
    {
        for (int i = 0; i < steps; i++)
        {
            Console.WriteLine($"Step {i + 1}");
            bank.Update(timeStep);
            Console.WriteLine(bank);
            Console.WriteLine();
        }
    }

    public static void Main(string[] args)
    {
        Bank bank = new Bank("National Bank", 0.01); // Federal investment rate of 1%
        bank.AddAccount(new BankAccount("Savings", 10000, 0.02, 5));
        bank.AddAccount(new BankAccount("Checking", 5000, 0.01, 2));
        bank.AddLoan(new Loan(20000, 0.05, 500, 24));
        bank.AddInvestment(new Investment(10000, 0.04, 12));

        BankSimulator simulator = new BankSimulator(bank, 1.0); // Daily time step

        // Running the simulation for 10 steps
        simulator.RunSimulation(10);
    }
}


















using System;
using System.Collections.Generic;

namespace ResourceSimulation
{
    public class Country
    {
        public string Name { get; set; }
        public List<Region> Regions { get; set; }

        public Country(string name)
        {
            Name = name;
            Regions = new List<Region>();
        }

        public void AddRegion(Region region)
        {
            Regions.Add(region);
        }

        public void UpdateRegion(string regionName, double newArea, Geography newGeography, Climate newClimate)
        {
            var region = Regions.Find(r => r.Name == regionName);
            if (region != null)
            {
                region.UpdateRegion(newArea, newGeography, newClimate);
            }
        }

        public void ExtractResources(string regionName, Dictionary<string, double> extractionAmounts)
        {
            var region = Regions.Find(r => r.Name == regionName);
            if (region != null)
            {
                region.ExtractResources(extractionAmounts);
            }
        }

        public void ChangeBoundaries(string regionName, double areaChange, Geography newGeography = null, Climate newClimate = null)
        {
            var region = Regions.Find(r => r.Name == regionName);
            if (region != null)
            {
                region.ChangeBoundaries(areaChange, newGeography, newClimate);
            }
        }

        public Resources CalculateTotalResources()
        {
            var totalResources = new Resources();

            foreach (var region in Regions)
            {
                totalResources.Energy += region.Resources.Energy;
                totalResources.Water += region.Resources.Water;
                totalResources.Oil += region.Resources.Oil;
                totalResources.Minerals += region.Resources.Minerals;
                totalResources.Lumber += region.Resources.Lumber;
                totalResources.Agriculture = totalResources.Agriculture.Merge(region.Resources.Agriculture);
                totalResources.Farming = totalResources.Farming.Merge(region.Resources.Farming);
            }

            return totalResources;
        }
    }

    public class Region
    {
        public string Name { get; set; }
        public double Area { get; set; } // in square kilometers
        public Geography Geography { get; set; }
        public Climate Climate { get; set; }
        public Resources Resources { get; set; }

        public Region(string name, double area, Geography geography, Climate climate)
        {
            Name = name;
            Area = area;
            Geography = geography;
            Climate = climate;
            Resources = new Resources();
            InitializeResources();
        }

        public void UpdateRegion(double newArea, Geography newGeography, Climate newClimate)
        {
            Area = newArea;
            Geography = newGeography;
            Climate = newClimate;
            InitializeResources();
        }

        public void ExtractResources(Dictionary<string, double> extractionAmounts)
        {
            foreach (var item in extractionAmounts)
            {
                if (Resources.Agriculture.ContainsKey(item.Key))
                {
                    Resources.Agriculture[item.Key] -= item.Value;
                    if (Resources.Agriculture[item.Key] < 0) Resources.Agriculture[item.Key] = 0;
                }
                else if (Resources.Farming.ContainsKey(item.Key))
                {
                    Resources.Farming[item.Key] -= item.Value;
                    if (Resources.Farming[item.Key] < 0) Resources.Farming[item.Key] = 0;
                }
                // Handle other finite resources similarly
            }
        }

        public void ChangeBoundaries(double areaChange, Geography newGeography = null, Climate newClimate = null)
        {
            Area += areaChange;
            if (newGeography != null) Geography = newGeography;
            if (newClimate != null) Climate = newClimate;
            InitializeResources();
        }

        private void InitializeResources()
        {
            Resources.Energy = CalculateEnergyResources();
            Resources.Water = CalculateWaterResources();
            Resources.Oil = CalculateOilResources();
            Resources.Minerals = CalculateMineralResources();
            Resources.Lumber = CalculateLumberResources();
            Resources.Agriculture = CalculateAgricultureResources();
            Resources.Farming = CalculateFarmingResources();
        }

        private double CalculateEnergyResources()
        {
            return Area * Geography.EnergyFactor * Climate.EnergyImpact;
        }

        private double CalculateWaterResources()
        {
            return Area * Geography.WaterFactor * Climate.WaterImpact;
        }

        private double CalculateOilResources()
        {
            return Area * Geography.OilFactor * Climate.OilImpact;
        }

        private double CalculateMineralResources()
        {
            return Area * Geography.MineralFactor;
        }

        private double CalculateLumberResources()
        {
            return Area * Geography.LumberFactor;
        }

        private Dictionary<string, double> CalculateAgricultureResources()
        {
            return new Dictionary<string, double>
            {
                { "Wheat", Area * Geography.AgricultureFactor * Climate.AgricultureImpact * 0.5 },
                { "Soy", Area * Geography.AgricultureFactor * Climate.AgricultureImpact * 0.3 },
                { "Corn", Area * Geography.AgricultureFactor * Climate.AgricultureImpact * 0.4 }
            };
        }

        private Dictionary<string, double> CalculateFarmingResources()
        {
            return new Dictionary<string, double>
            {
                { "Cows", Area * Geography.FarmingFactor * Climate.FarmingImpact * 0.6 },
                { "Pigs", Area * Geography.FarmingFactor * Climate.FarmingImpact * 0.5 },
                { "Chicken", Area * Geography.FarmingFactor * Climate.FarmingImpact * 0.8 },
                { "Milk", Area * Geography.FarmingFactor * Climate.FarmingImpact * 0.7 },
                { "Eggs", Area * Geography.FarmingFactor * Climate.FarmingImpact * 0.9 }
            };
        }
    }

    public class Geography
    {
        public double EnergyFactor { get; set; }
        public double WaterFactor { get; set; }
        public double OilFactor { get; set; }
        public double MineralFactor { get; set; }
        public double LumberFactor { get; set; }
        public double AgricultureFactor { get; set; }
        public double FarmingFactor { get; set; }

        public Geography(double energyFactor, double waterFactor, double oilFactor, double mineralFactor, double lumberFactor, double agricultureFactor, double farmingFactor)
        {
            EnergyFactor = energyFactor;
            WaterFactor = waterFactor;
            OilFactor = oilFactor;
            MineralFactor = mineralFactor;
            LumberFactor = lumberFactor;
            AgricultureFactor = agricultureFactor;
            FarmingFactor = farmingFactor;
        }
    }

    public class Climate
    {
        public double EnergyImpact { get; set; }
        public double WaterImpact { get; set; }
        public double OilImpact { get; set; }
        public double AgricultureImpact { get; set; }
        public double FarmingImpact { get; set; }

        public Climate(double energyImpact, double waterImpact, double oilImpact, double agricultureImpact, double farmingImpact)
        {
            EnergyImpact = energyImpact;
            WaterImpact = waterImpact;
            OilImpact = oilImpact;
            AgricultureImpact = agricultureImpact;
            FarmingImpact = farmingImpact;
        }
    }

    public class Resources
    {
        public double Energy { get; set; }
        public double Water { get; set; }
        public double Oil { get; set; }
        public double Minerals { get; set; }
        public double Lumber { get; set; }
        public Dictionary<string, double> Agriculture { get; set; }
        public Dictionary<string, double> Farming { get; set; }

        public Resources()
        {
            Agriculture = new Dictionary<string, double>();
            Farming = new Dictionary<string, double>();
        }

        public Resources Merge(Dictionary<string, double> resources)
        {
            var merged = new Dictionary<string, double>(Agriculture);
            foreach (var item in resources)
            {
                if (merged.ContainsKey(item.Key))
                {
                    merged[item.Key] += item.Value;
                }
                else
                {
                    merged[item.Key] = item.Value;
                }
            }
            return new Resources { Agriculture = merged };
        }

        public Resources MergeFarming(Dictionary<string, double> resources)
        {
            var merged = new Dictionary<string, double>(Farming);
            foreach (var item in resources)
            {
                if (merged.ContainsKey(item.Key))
                {
                    merged[item.Key] += item.Value;
                }
                else
                {
                    merged[item.Key] = item.Value;
                }
            }
            return new Resources { Farming = merged };
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var region1Geography = new Geography(0.8, 0.5, 0.6, 0.7, 0.4, 0.3, 0.5);
            var region1Climate = new Climate(1.1, 0.9, 1.0, 0.8, 0.7);
            var region1 = new Region("Northern Region", 500000, region1Geography, region1Climate);

            var region2Geography = new Geography(0.6, 0.7, 0.5, 0.6, 0.8, 0.4, 0.6);
            var region2Climate = new Climate(1.0, 1.1, 0.9, 0.9, 0.8);
            var region2 = new Region("Southern Region", 500000, region2Geography, region2Climate);

            var country = new Country("SampleLand");
            country.AddRegion(region1);
            country.AddRegion(region2);

            // Example of resource extraction
            country.ExtractResources("Northern Region", new Dictionary<string, double>
            {
                { "Wheat", 1000 },
                { "Cows", 200 }
            });

            // Example of changing boundaries
            country.ChangeBoundaries("Southern Region", -10000, new Geography(0.7, 0.8, 0.6, 0.5, 0.6, 0.5, 0.7));

            var totalResources = country.CalculateTotalResources();

            Console.WriteLine("Total Resources:");
            Console.WriteLine($"Energy: {totalResources.Energy}");
            Console.WriteLine($"Water: {totalResources.Water}");
            Console.WriteLine($"Oil: {totalResources.Oil}");
            Console.WriteLine($"Minerals: {totalResources.Minerals}");
            Console.WriteLine($"Lumber: {totalResources.Lumber}");

            Console.WriteLine("\nAgriculture Resources:");
            foreach (var item in totalResources.Agriculture)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            Console.WriteLine("\nFarming Resources:");
            foreach (var item in totalResources.Farming)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}

 */