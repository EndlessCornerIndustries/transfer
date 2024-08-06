using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transfer.Models
{
    public interface IBank {

    }

    public class Bank : IBank
    {
        private List<BankAccount> _accounts;

        public Bank()
        {

        }
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
 */