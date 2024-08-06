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

/*
using System;
using System.Collections.Generic;
using MathNet.Numerics.Distributions;

public class Business
{
    public string Name { get; set; }
    public double Revenue { get; set; }
    public double Expenses { get; set; }
    public double Profit { get; set; }
    public double MarketingBudget { get; set; }
    public double InnovationInvestment { get; set; }
    public double TaxRate { get; set; }
    public double EnvironmentalImpactCost { get; set; }
    public double EmployeeCost { get; set; }
    public double BenefitsCost { get; set; }
    public double UtilityCost { get; set; }
    public double RentCost { get; set; }
    public int NumberOfEmployees { get; set; }
    public int JobOpenings { get; set; }
    public int PromotedEmployees { get; set; }
    public int NewHires { get; set; }
    public bool UnionizedWorkers { get; set; }

    public Business(string name)
    {
        Name = name;
        Revenue = 0;
        Expenses = 0;
        Profit = 0;
        MarketingBudget = 10000;
        InnovationInvestment = 5000;
        TaxRate = 0.2;
        EnvironmentalImpactCost = 1000;
        EmployeeCost = 30000;
        BenefitsCost = 5000;
        UtilityCost = 2000;
        RentCost = 4000;
        NumberOfEmployees = 50;
        JobOpenings = 5;
        PromotedEmployees = 0;
        NewHires = 0;
        UnionizedWorkers = false;
    }

    public void PerformMarketing()
    {
        // Simple marketing model: higher budget can lead to higher revenue
        Revenue += MarketingBudget * 0.1;
    }

    public void InvestInInnovation()
    {
        // Innovation can increase revenue based on investment
        Revenue += InnovationInvestment * 0.05;
    }

    public void ApplyTaxes()
    {
        // Taxes are applied to profit
        Profit -= Profit * TaxRate;
    }

    public void CalculateExpenses()
    {
        Expenses = NumberOfEmployees * (EmployeeCost + BenefitsCost) + UtilityCost + RentCost + EnvironmentalImpactCost;
    }

    public void UpdateEmployment()
    {
        // Update number of employees based on new hires and promotions
        NumberOfEmployees += NewHires + PromotedEmployees;
        NewHires = 0;
        PromotedEmployees = 0;
    }

    public void ApplyEnvironmentalImpact()
    {
        // Environmental impact cost affects expenses
        Expenses += EnvironmentalImpactCost;
    }

    public void CalculateProfit()
    {
        Profit = Revenue - Expenses;
    }

    public void Update(double timeStep)
    {
        PerformMarketing();
        InvestInInnovation();
        CalculateExpenses();
        ApplyEnvironmentalImpact();
        CalculateProfit();
        ApplyTaxes();
        UpdateEmployment();
    }

    public override string ToString()
    {
        return $"{Name}: Revenue = {Revenue:F2}, Expenses = {Expenses:F2}, Profit = {Profit:F2}, Employees = {NumberOfEmployees}";
    }
}

public class BusinessSimulator
{
    private List<Business> businesses;
    private double timeStep;
    private Random random;

    public BusinessSimulator(double timeStep)
    {
        businesses = new List<Business>();
        this.timeStep = timeStep;
        random = new Random();
    }

    public void AddBusiness(Business business)
    {
        businesses.Add(business);
    }

    public void RunSimulation(int steps)
    {
        for (int i = 0; i < steps; i++)
        {
            Console.WriteLine($"Step {i + 1}");
            foreach (var business in businesses)
            {
                // Simulate random factors
                business.NewHires = random.Next(0, business.JobOpenings + 1);
                business.PromotedEmployees = random.Next(0, 5); // Number of promoted employees
                
                // Apply various updates
                business.Update(timeStep);
                Console.WriteLine(business);
            }
            Console.WriteLine();
        }
    }

    public static void Main(string[] args)
    {
        BusinessSimulator simulator = new BusinessSimulator(1.0);

        // Adding some businesses
        simulator.AddBusiness(new Business("TechCorp"));
        simulator.AddBusiness(new Business("GreenEnergy"));

        // Running the simulation for 10 steps
        simulator.RunSimulation(10);
    }
}

 */