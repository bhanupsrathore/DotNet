namespace Banking;

//sealed class cannot be used as a base class
sealed class CurrentAccount : Account, IChargeable
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

    //explicit interface implementation
    bool IChargeable.Withdraw(decimal fees)
    {
        if(Balance < 0)
        {
            Balance -= fees;
            return true;
        }
        return false;
    }
}
