var shop = new Shopping.ShopDbContext();
if(args.Length == 0)
{
    foreach(var product in shop.Products)
        Console.WriteLine("{0}\t{1}\t{2}", product.ProductId, product.Price, product.Stock);
}
else
{
    int pno = int.Parse(args[0]);
    var product = shop.Products
                    .Where(p => p.ProductId == pno)
                    .Include(p => p.Orders) //eager loading of child entities
                    .FirstOrDefault();
    if(product is not null)
    {
        foreach(var order in product.Orders)
            Console.WriteLine("{0}\t{1}\t{2:yyyy-MMM-dd}", order.CustomerId, order.Quantity, order.OrderDate);
    }
}   
