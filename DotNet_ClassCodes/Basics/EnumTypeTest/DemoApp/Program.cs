using System;

class Program
{
    private static void MakeRisky(Investment i)
    {
        i.AllowRisk(true);
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome Investor.");
        double s = double.Parse(args[0]);
        int y = int.Parse(args[1]);
        Investment inv = new Investment(s, y);
        Console.WriteLine("Income in risk-free investment is {0:0.00}", inv.Income());
        MakeRisky(inv); 
        Console.WriteLine("Income in low-risk investment is {0:0.00}", inv.Income());
        inv.AllowRisk(RiskLevel.High);
        Console.WriteLine("Income in high-risk investment is {0:0.00}", inv.Income());
    }
}
