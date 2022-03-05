//C# (from version 9.0) supports top-level statements which are inserted
//by the compiler into entry-point method of auto-generated Program class.
//Top-level statements cannot implement user-defined types or multiple local
//functions with same name

using System;

//variadic local function can accept variable number of arguments
double Average(double first, double second, params double[] remaining)
{
    double total = first + second;
    foreach(double value in remaining)
    {
        total += value;
    }
    return total / (remaining.Length + 2);
}

//out is same as ref but it can accept uninitialized argument
double AverageWithDeviation(double first, double second, out double deviation)
{
    deviation = first > second ? (first - second) / 2 : (second - first) / 2;
    return (first + second) / 2;
}

Console.WriteLine("Average of two values = {0}", Average(23.4, 26.1));
Console.WriteLine("Average of three values = {0}", Average(23.4, 26.1, 19.2));
Console.WriteLine("Average of five values = {0}", Average(23.4, 26.1, 19.2, 34.7, 11.9));
if(args.Length > 1)
{
    double x = double.Parse(args[0]);
    double y = double.Parse(args[1]);
    double a = AverageWithDeviation(x, y, out double d);
    Console.WriteLine("Average of input values is {0:0.000} with a deviation of {1:0.000}", a, d);
}
