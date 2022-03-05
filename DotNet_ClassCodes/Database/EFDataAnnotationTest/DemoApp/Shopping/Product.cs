namespace Shopping;

//POCO
[Table("ProductInfo")]
public class Product
{
    //persistent properties
    [Column("ProductNo")]
    public int ProductId { get; set; }

    public decimal Price { get; set; }

    public int Stock { get; set; }

    //navigation property
    public ICollection<Order> Orders { get; set; }
}

