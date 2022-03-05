using Finance;
using System.Reflection;
using RateFunc = System.Func<double, int, float>;

class Program
{
    static void Main(string[] args)
    {
        double p = double.Parse(args[0]);
        Type t = Type.GetType(args[1]);
        object scheme = Activator.CreateInstance(t); 
        MethodInfo mi = t.GetMethod(args[2]);
        RateFunc interest = mi.CreateDelegate<RateFunc>(scheme);
        MaxDurationAttribute md = mi.GetCustomAttribute<MaxDurationAttribute>();
        int m = md?.Limit ?? 10; //md != null ? md.Limit : 10;
        for(int n = 1; n <= m; ++n)
        {
            float r = interest(p, n);
            float i = r / 1200;
            double emi = p * i / (1 - Math.Pow(1 + i, -12 * n));
            Console.WriteLine("{0}\t{1:0.00}", n, emi);
        }
    }
}

