namespace Banking;

sealed class SavingsAccount : Account, IProfitable
{
    const decimal MinBal = 5000;

    internal SavingsAccount()
    {
        Balance = MinBal;
    }

    public override void Deposit(decimal amount)
    {
        Balance += amount;
    }

    public override void Withdraw(decimal amount)
    {
        if(Id < 0)
            throw new NotSupportedException("Account is frozen");
        if(Balance - amount < MinBal)
            throw new InsufficientFundsException();
        Balance -= amount;
    }

    public decimal AddInterest(int months)
    {
        decimal rate = Balance < 5 * MinBal ? 4 : 5;
        decimal interest = Balance * rate * months / 1200;
        Balance += interest;
        return interest;
    }
}