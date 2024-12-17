namespace Solid._03_LSP.Bad;

public class BankAccount
{
    // virtual: posso ou não substittuir essa classe
    public virtual void Withdraw(decimal amount)
    {
        
    }
}

public class SavingsAccount : BankAccount
{
    public decimal Balance { get; set; }

    public override void Withdraw(decimal amount)
    {
        if (Balance < amount)
        {
            throw new Exception("Insufficient balance");
        }
        Balance -= amount;
        Console.WriteLine($"Withdraw: {amount}");
    }
}