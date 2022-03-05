//event sink
class Subscriber
{
    private Publisher pub;

    public void Run()
    {
        pub = new Publisher();
        pub.Available += pub_Available;
        pub.Available += ShowTime; //multicasting
        pub.Publish(5);
    }

    private void pub_Available(object sender, QuoteEventArgs e)
    {
        Console.WriteLine("Received quote with value {0:0.00}", e.CurrentValue);
        if(e.CurrentValue > 50)
            pub.Available -= ShowTime;
    }

    private void ShowTime(object sender, QuoteEventArgs e)
    {
        Console.WriteLine(DateTime.Now);
    }
}
