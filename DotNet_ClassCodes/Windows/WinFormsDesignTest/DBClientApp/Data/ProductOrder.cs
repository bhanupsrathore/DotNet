namespace DBClientApp.Data
{
    public class ProductOrder
    {
        public string CustomerId { get; set; } = string.Empty;

        public int Quantity { get; set; }

        public DateTime OrderDate { get; set; }
    }

}
