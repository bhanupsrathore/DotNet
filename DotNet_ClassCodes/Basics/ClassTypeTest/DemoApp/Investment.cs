//user-defined reference type
class Investment
{
    //instance fields - each instance has is its own separate values for them
    private double sum;
    private int years;
    private bool risk;

    public Investment(double amount, int period)
    {
        sum = amount;
        years = period;
        risk = false;
    }

    public void AllowRisk(bool yes)
    {
        risk = yes;
    }

    public double Income()
    {
        float rate = risk ? 8 : 6;
        double amount= sum * System.Math.Pow(1 + rate / 100, years);
        return amount - sum;
    }
}