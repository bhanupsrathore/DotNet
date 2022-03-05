using Taxation;

class Auditor
{
    public Auditor()
    {
        Console.WriteLine("Acquiring departmental resource.");
    }

    public void Audit(ITaxPayer person, string id)
    {
        if(id.Length < 4)
            throw new ArgumentException("Invalid tax-payer ID");
        Console.WriteLine("Payment for {0} is {1:0.00}", id, person.IncomeTax() + 500);
    }

    public void Dispose()
    {
        Console.WriteLine("Releasing departmental resource.");
    }
}

class Program
{
    private static void ProcessDealer(decimal amount)
    {
        var d = new Dealer {TotalSales = amount}; //instance initializer
        var a = new Auditor();
        a.Audit(d, "Jack");
        a.Dispose();
    }

    private static void ProcessWorker(decimal amount, string name)
    {
        var w = new Worker {MonthlyWages = amount};
        var a = new Auditor();
        try
        {
            a.Audit(w, name);
        }
        finally
        {
            a.Dispose();
        }
    }

    static void Main(string[] args)
    {
        try
        {
            decimal amt = decimal.Parse(args[0]);
            if(args.Length < 2)
                ProcessDealer(amt);
            else
                ProcessWorker(amt, args[1]);
        }      
        catch(Exception ex)
        {
            Console.WriteLine("Error: {0}", ex.Message);
        }
    }
}