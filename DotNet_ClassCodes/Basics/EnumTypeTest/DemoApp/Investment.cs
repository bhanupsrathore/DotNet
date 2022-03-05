//a value type containing integer type constant options
enum RiskLevel {None, Low, High}

class Investment
{
    private double sum;
    private int years;
    private RiskLevel risk;

    public Investment(double amount, int period)
    {
        sum = amount;
        years = period;
        risk = RiskLevel.None;
    }

    public void AllowRisk(bool yes)
    {
        risk = yes ? RiskLevel.Low : RiskLevel.None;
    }

    //overloading existing method with different list of parameter types
    public void AllowRisk(RiskLevel level)
    {
        risk = level;
    }

    public double Income()
    {
        float rate;
        switch(risk)
        {
            case RiskLevel.Low:
                rate = 8;
                break; //always required
            case RiskLevel.High:
                rate = 11;
                break;
            default:
                rate = 6;
                break;
        }
        double amount= sum * System.Math.Pow(1 + rate / 100, years);
        return amount - sum;
    }
}