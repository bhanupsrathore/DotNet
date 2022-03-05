//A record is defined for constructing immutable data-object.
//By default a C# record is a reference type whose class is
//auto-generated to contain get-only properties corresponding
//to the parameters specified in its definition along with a 
//a constructor to initialize those properties and overrides
//for ToString, GetHashCode and Equals methods.
record Item(string Name, string Brand);

//mutable value-type record
record struct Customer(string Id, double Purchase, int Rating);

class Shop
{
    public Item[] GetItems()
    {
		return new Item[] {
			new Item("cpu", "intel"),
			new Item("ssd", "samsung"),
			new Item("mouse", "microsoft"),
			new Item("hdd", "samsung"),
			new Item("motherboard", "intel"),
			new Item("keyboard", "logitech"),
			new Item("ssd", "seagate"),
			new Item("monitor", "samsung"),
		};
    }

    public ICollection<Customer> GetCustomers()
    {
		ICollection<Customer> customers = new List<Customer>();
		customers.Add(new Customer("rohan", 36000, 4));
		customers.Add(new Customer("prashant", 45000, 2));
		customers.Add(new Customer("akshay", 24000, 1));
		customers.Add(new Customer("rutuja", 68000, 5));
		customers.Add(new Customer("upendra", 54000, 3));
		customers.Add(new Customer("sanket", 13000, 2));
		customers.Add(new Customer("dhananjay", 92000, 4));
		customers.Add(new Customer("rani", 49000, 5));
		customers.Add(new Customer("pradeep", 29000, 1));
		customers.Add(new Customer("nikhil", 52000, 3));
		return customers;
    }
}