namespace Finance;

public class PersonalLoan
{
    [MaxDuration(4)]
    public float Common(double amount, int period) => 10 + 0.5f * period;

    public float Employees(double amount, int period)
    {
        return 0.5f * Common(amount, period);
    }    
}