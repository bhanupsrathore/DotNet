class Program
{
    static void Main(string[] args)
    {
        double p = double.Parse(args[0]);
        Type t = Type.GetType(args[1]);
        //members applied to a dynamic type identifier will be 
        //resolved by the runtime-binder and not by the compiler
        dynamic scheme = Activator.CreateInstance(t); 
        int m = 10;
        for(int n = 1; n <= m; ++n)
        {
            float r = scheme.Common(p, n); //duck typing
            float i = r / 1200;
            double emi = p * i / (1 - Math.Pow(1 + i, -12 * n));
            Console.WriteLine("{0}\t{1:0.00}", n, emi);
        }
    }
}