using System;

class Program
{
    //accepting value type by reference
    private static void MakeRisky(ref Investment i)
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
        MakeRisky(ref inv); //passing value type by reference
        Console.WriteLine("Income in low-risk investment is {0:0.00}", inv.Income());
        //Investment second = new Investment();
        //Investment third = null;
    }
}
