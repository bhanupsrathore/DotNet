class Program
{
    //non-verifiable pointers can only be used in an unsafe context 
    //(a scope of code marked with unsafe keyword) and this context
    //can only be compiled (with /unsafe option) if the project
    //allows unsafe blocks (see DemoApp.csproj)
    private unsafe static double AddSquares(double[] values)
    {
        double sum = 0;
        double* pSum = &sum; //directly taking address of a value on stack
        //address of a value enclosed in an object on the heap can
        //only be taken within a fixed statement block which pins
        //this object so that it is not moved during garbage collection
        fixed(double* pValue = &values[0])
        {
            for(int i = 0; i < values.Length; ++i)
                *pSum += pValue[i] * pValue[i];
        }
        return sum;
    }

    static void Main(string[] args)
    {
        double[] list = args.Select(double.Parse).ToArray();
        Console.WriteLine("Sum of Squares = {0:0.000}", AddSquares(list));
    }
}