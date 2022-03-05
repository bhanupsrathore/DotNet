class QuoteEventArgs : EventArgs
{
    public double CurrentValue { get; }

    public QuoteEventArgs(double value)
    {
        CurrentValue = value;
    }
}

//event source
class Publisher
{
    public event EventHandler<QuoteEventArgs> Available;

    public void Publish(int count)
    {
        var rdm = new Random();
        for(int i = 1; i <= count; ++i)
        {
            for(int t = Environment.TickCount + 1000 * i; Environment.TickCount < t;);
            double val = 0.01 * rdm.Next(1000, 10000);
            Available?.Invoke(this, new QuoteEventArgs(val)); //raising the event 
        }
    }
}
