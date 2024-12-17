namespace Solid._03_LSP.Good;

public abstract class BankAccount
{
    public decimal Balance { get; protected set; } // protected evita de alterar o valor
    
    public abstract void Withdraw(decimal amount);
}