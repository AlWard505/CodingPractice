using System;
using System.Collections.Generic;
//using this tutorial https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/intro-to-csharp/introduction-to-classes
namespace _10_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new bankaccount(Console.ReadLine(), 10000);
            Console.WriteLine($"Account {account.number} was created for {account.owner} with {account.balance} initial balance.");
            account.withdrawl(500, DateTime.Now, "Rent payment");
            Console.WriteLine(account.balance);
            account.deposit(100, DateTime.Now, "Friend paid me back");
            Console.WriteLine(account.balance);
        }
    }
    //defines the class
    public class bankaccount
    {
        //creates a account number that stays static across all versions of this class
        private static int accountNumberSeed = 11111111;
        //creates properties of the class
        public string number { get; }
        public string owner { get; set; }
        public decimal balance 
        { 
            get
            {
                decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    balance += item.amount;
                }
                return balance;
            }
        }

        private List<Transaction> allTransactions = new List<Transaction>();
        //defines a function that run when a new class is created
        //called the constructor
        public bankaccount(string name, decimal initialbalance)
        {
            this.owner = name;
            this.number = accountNumberSeed.ToString();
            accountNumberSeed++;
            deposit(initialbalance, DateTime.Now, "inital balance");
        }
        public void deposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Deopsit must be positive");
            };
            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
        }

        public void withdrawl(decimal amount, DateTime date, string note)
        {
            if(amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount withdrawn must be positive");
            }
            if (balance - amount < 0)
            {
                throw new InvalidOperationException("Insufficient funds");
            }
            var withdrawl = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawl);
        }
    }
    public class Transaction
    {
        public decimal amount { get; }
        public DateTime date { get; }
        public string notes { get; }
        public Transaction(decimal amount, DateTime date, string notes)
        {
            this.amount = amount;
            this.date = date;
            this.notes = notes;
        }
    }
}
