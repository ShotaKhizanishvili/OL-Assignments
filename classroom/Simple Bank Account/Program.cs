namespace Simple_Bank_Account
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount(1000);
            account.Deposit(500);
            account.Withdraw(2000);
            account.Withdraw(100);

            Console.WriteLine(account.ToString());
        }
    }
    public class BankAccount
    {
        private decimal _balance;

        public BankAccount(decimal balance)
        {
            Console.WriteLine($"Initializing new bank account with a balance of ${balance}.");
            _balance = balance;
        }

        public void Deposit(decimal funds)
        {
            if (funds <= 0)
            {
                throw new ArgumentOutOfRangeException("Funds for deposit must be more than 0.");
            }
            Console.WriteLine($"Depositing ${funds}...");
            this._balance += funds;
            Console.WriteLine($"New balance is ${this._balance}");
        }
        public void Withdraw(decimal funds)
        {
            if (funds <= 0)
            {
                throw new ArgumentOutOfRangeException("Funds for withdraw must be more than 0.");
            }
            if (funds > this._balance)
            {
                Console.WriteLine("Insufficient funds. Transaction denied.");
                return;
            }
            Console.WriteLine($"Withdrawing {funds}");
            this._balance -= funds;
            Console.WriteLine($"New balance is ${this._balance}.");
        }
        public override string ToString()
        {
            return $"Current balance: ${this._balance}";
        }
    }

}