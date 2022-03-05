namespace Finance;

public class HomeLoan
{
    public float Common(double amount, int period) => amount < 1000000 ? 9.5f : 9.0f;

    [MaxDuration(Limit = 12)]
    public float Women(double amount, int period)
    {
        return Common(amount, period) - 1;
    }
}
