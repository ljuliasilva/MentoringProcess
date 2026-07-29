namespace BankingSystem
{
    internal class BankAccount
    {
        private string holder;
        private double balance;

        public BankAccount(string name)
        {
            holder = name;
            balance = 0;
        }

        public double GetBalance()
        {
            return balance;
        }

        public void Deposit(double amount)
        {
            balance += amount;
        }

        public void Withdraw(double amount)
        {
            balance -= amount;
        }
    }
}
