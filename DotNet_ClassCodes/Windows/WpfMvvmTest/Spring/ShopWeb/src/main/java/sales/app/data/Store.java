package sales.app.data;

import java.util.ArrayList;
import java.util.List;

import org.springframework.stereotype.Service;

@Service
public class Store {
	
	public final static List<Product> products = new ArrayList<>();
	
	static {
		products.add(new Product(201, 4515, 40));
		products.add(new Product(202, 8235, 20));
		products.add(new Product(203, 6355, 30));
		products.add(new Product(204, 7285, 15));
	}
	
	public List<Product> findAllProducts() {
		return products;
	}
	
	public Product findProductById(int id) {
		return products.stream()
				.filter(p -> p.id == id)
				.findFirst()
				.orElse(null);
	}
	
	public boolean saveProduct(Product entry) {
		Product product = this.findProductById(entry.id);
		if(product != null) {
			if(!entry.valid())
				throw new IllegalArgumentException("Invalid product data");
			product.price = entry.price;
			product.stock = entry.stock;
			return true;
		}
		return false;	
	}
}
