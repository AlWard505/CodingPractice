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
        private static int accountNumberSeed = 1234567890;
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
}
