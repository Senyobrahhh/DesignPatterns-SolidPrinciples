namespace Project;

public class BankAccount
{
    private decimal balance;

    public BankAccount(decimal balance)
    {
        this.balance = balance;
    }

    public decimal GetBalance()
    {
        return balance;
    }

    public void Deposit(decimal amount)
    {
        if (amount < 0)
        {
            throw new ArgumentException("Amount cannot be negative");
        }
        else
        {
            balance += amount;
        }
    }

    public void Withdraw(decimal amount)
    {
        if (amount > balance)
        {
            throw new ArgumentException("Insufficient funds");
        }
        else if(amount <= 0)
        {
            throw new ArgumentException("Amount cannot be negative");
        }
        else
        {
            balance -= amount;
        }
    }
}