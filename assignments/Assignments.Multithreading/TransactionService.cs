namespace Assignments.Multithreading;

public class TransactionService
{
    public void Transfer(BankAccount fromAccount, BankAccount toAccount, decimal amount)
    {
        lock (fromAccount)
        {
            lock (toAccount)
            {
                if (amount > fromAccount.Balance)
                {
                    Console.WriteLine($"{fromAccount.Iban} has Insufficient funds");
                    return;
                }

                fromAccount.Balance -= amount;
                toAccount.Balance += amount;
            }
        }
    }
}