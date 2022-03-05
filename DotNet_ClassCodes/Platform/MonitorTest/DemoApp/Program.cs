var acc = new JointAccount();
acc.Deposit(5000);
Console.WriteLine("Joint account opened for Jack and Jill");
Console.WriteLine("Initial Balance: {0}", acc.Balance);
var child = new Thread(() =>
{
    Console.WriteLine("Jack is withdrawing 3000...");
    if(!acc.Withdraw(3000))
        Console.WriteLine("Jack's withdraw operation failed!");
});
child.Start();
Console.WriteLine("Jill is withdrawing 4000...");
if(!acc.Withdraw(4000))
    Console.WriteLine("Jill's withdraw operation failed!");
child.Join(); //this (main) thread waits for child to exit
Console.WriteLine("Final Balance: {0}", acc.Balance);
