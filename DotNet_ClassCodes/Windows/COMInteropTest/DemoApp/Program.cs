using FolrSeriesLib;

class SquareSum : IReduceTerms
{
    public double Reduce(double left, double right)
    {
        return left + right * right;
    }
}

class Program
{
    [STAThread]
    public static void Main(string[] args)
    {
        double t1 = double.Parse(args[0]);
        double t2 = double.Parse(args[1]);
        double t3 = double.Parse(args[2]);
        int n = int.Parse(args[3]);
        var series = (IGenerateTerms) new CommonSequence(); //RCW will be returned
        series.Begin(t1, t2, t3);
        Console.WriteLine("Sum of Terms: {0}", series.Combine(n));
        Console.WriteLine("Sum of Squares: {0}", series.Combine(n, new SquareSum())); //CCW will be passes
    }
}
