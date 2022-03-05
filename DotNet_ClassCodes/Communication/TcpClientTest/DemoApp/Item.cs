//immutable value type record
readonly record struct Item(double Price, int Stock)
{
    public static Item Parse(string info) //info="price:2000,stock:20"
    {
        string[] parts = info.Split(','); //parts[0]="price:2000"; parts[1]="stock:20"
        double price = double.Parse(parts[0].Substring(6)); //price=2000
        int stock = int.Parse(parts[1].Substring(6));
        return new Item(price, stock);
    }
}
