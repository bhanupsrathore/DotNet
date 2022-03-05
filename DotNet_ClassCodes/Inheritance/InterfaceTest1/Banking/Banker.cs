namespace Banking;

//static class can only define static members
//it does not support instance constructor
public static class Banker
{
    private static long nid;

    //class constructor is called when the class is used for the first time
    static Banker()
    {
        nid = DateTime.Now.Ticks % 1000000L;
    }

    public static Account OpenCurrentAccount()
    {
        var acc = new CurrentAccount();
        acc.Id = 10000000L + nid++;
        return acc;
    }

    public static Account OpenSavingsAccount()
    {
        var acc = new SavingsAccount();
        acc.Id = 20000000L + nid++;
        return acc;
    }

    //Extension method is a member of a static class whose first
    //parameter is qualified with 'this' modifier. Such a method
    //can be called as an instance method of its first parameter type.
    public static void Freeze(this Account target)
    {
        target.Id = -target.Id;
    }
}
