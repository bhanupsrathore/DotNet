class JointAccount
{
    public int Balance { get; private set; }

    public bool Withdraw(int amount)
    {
        bool success = false;
        if(Balance >= amount)
        {
            CountMoney(amount);
            Balance -= amount;
            success = true;
        }
        return success;
    }

    public void Deposit(int amount)
    {
        CountMoney(amount);
        Balance += amount;
    }

    private static void CountMoney(int amount)
    {
        int t = Environment.TickCount + amount / 100;
        while(Environment.TickCount < t);
    }
}