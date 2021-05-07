using System;

namespace _10_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var account = new bankaccount(Console.ReadLine(), 1000);
                Console.WriteLine($"Account {account.number} was created for {account.owner} with {account.balance} initial balance.");
            }
        }
    }
    public class bankaccount
    {
        private static int accountNumberSeed = 11111111;
        public string number { get; }
        public string owner { get; set; }
        public decimal balance { get; }
        public bankaccount(string name, decimal initialbalance)
        {
            this.owner = name;
            this.balance = initialbalance;
            this.number = accountNumberSeed.ToString();
            accountNumberSeed++;
        }
        public void deposit(decimal amount, DateTime date, string note)
        {

        }

        public void withdrawl(decimal amount, DateTime date, string note)
        {

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
