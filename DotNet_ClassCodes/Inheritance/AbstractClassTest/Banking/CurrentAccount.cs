namespace Banking;

//sealed class cannot be used as a base class
sealed class CurrentAccount : Account
{
    public override void Deposit(decimal amount)
    {
        Balance += amount;
    }

    public override void Withdraw(decimal amount)
    {
        if(Id < 0)
            throw new NotSupportedException("Account is frozen");
        Balance -= amount;
    }
}
