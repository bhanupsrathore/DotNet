Shop shop = new Shop();
if(args[0] == "items")
{
    Item[] items = shop.GetItems();
    items.Where(i => i.Brand == args[1])
        .Select(i => i.Name)
        .PrintEach(); //LINQ in fluent form
}
else if(args[0] == "customers")
{
    double limit = double.Parse(args[1]);
    ICollection<Customer> customers = shop.GetCustomers();
    var selection = from c in customers
                    where c.Purchase >= limit
                    orderby c.Rating descending
                    select new //creating objects of anonymous type
                    {
                        Name = c.Id.ToUpper(),
                        Stars = new String('*', c.Rating)
                    }; //LINQ in declarative form
    foreach(var entry in selection)
        Console.WriteLine("{0}\t{1}", entry.Stars, entry.Name);
}