float SafeScheme(int n)
{
    return n < 3 ? 6 : 7;
}

Console.Write("Sum: ");
double s = double.Parse(Console.ReadLine());
Console.Write("Years: ");
int y = int.Parse(Console.ReadLine());
var inv = new Investment(years: y, sum: s); //passing paremeters by names
Console.WriteLine("Income in risk-free investment: {0:0.00}", inv.Income(SafeScheme));
//passing lambda expression (anonymous method) for delegate
Console.WriteLine("Income in riskful investment: {0:0.00}", inv.Income(n => 9 + 0.1f * n));


