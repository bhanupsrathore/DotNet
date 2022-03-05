package sales.app.data;


public class Product {
	
	int id;
	double price;
	int stock;
	
	public Product(int id, double price, int stock) {
		super();
		this.id = id;
		this.price = price;
		this.stock = stock;
	}

	public final int getId() {
		return id;
	}

	public final void setId(int id) {
		this.id = id;
	}

	public final double getPrice() {
		return price;
	}

	public final void setPrice(double price) {
		this.price = price;
	}

	public final int getStock() {
		return stock;
	}

	public final void setStock(int stock) {
		this.stock = stock;
	}

	public boolean valid() {
		return stock >= 5 && stock <= 50;
	}	
	
}
