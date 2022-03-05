class JointAccount
{
    public int Balance { get; private set; }

    public bool Withdraw(int amount)
    {
        bool success = false;
        Monitor.Enter(this);
        try
        {
            if(Balance >= amount)
            {
                CountMoney(amount);
                Balance -= amount;
                success = true;
            }
        }
        finally
        {
            Monitor.Exit(this);
        }
        return success;
    }

    public void Deposit(int amount)
    {
        //implicit calls to Monitor.Enter and Monitor.Exit
        lock(this)
        {
            CountMoney(amount);
            Balance += amount;
            Monitor.Pulse(this); 
            //use Monitor.PulseAll(this) for multiple waiting threads
        }
    }

    public void WithdrawAfterDeposit(int amount)
    {
        lock(this)
        {
            do
            {
                //release the monitor assigned to this object and wait
                //for some other thread to call Monitor.Pulse on this object
                //after which reaquire the monitor
                Monitor.Wait(this); 
            }
            while(Balance < amount);
        }
        Withdraw(amount);
    }

    private static void CountMoney(int amount)
    {
        int t = Environment.TickCount + amount / 100;
        while(Environment.TickCount < t);
    }
}