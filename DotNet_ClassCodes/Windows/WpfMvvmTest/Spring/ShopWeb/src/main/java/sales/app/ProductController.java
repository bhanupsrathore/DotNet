package sales.app;

import java.util.*;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import sales.app.data.*;

@RestController
@RequestMapping("/api/products")
public class ProductController {

	@Autowired
	private Store store;
	
	
	@GetMapping("/")
	public ResponseEntity<List<Product>> getProducts() {
		return new ResponseEntity<>(store.findAllProducts(), HttpStatus.OK);
	}
	
	@GetMapping("/{id}")
	public ResponseEntity<Product> getProduct(@PathVariable("id") int id) {
		Product entry = store.findProductById(id);
		if(entry == null) 
			return new ResponseEntity<>(HttpStatus.NOT_FOUND);
		return new ResponseEntity<>(entry, HttpStatus.OK);
	}
	
	@PutMapping("/")
	public ResponseEntity<HttpStatus> putProduct(@RequestBody Product input) {
		try {
			if(store.saveProduct(input))
				return new ResponseEntity<>(HttpStatus.OK);
			return new ResponseEntity<>(HttpStatus.NOT_FOUND);
		}catch(IllegalArgumentException e) {
			return new ResponseEntity<>(HttpStatus.BAD_REQUEST);
		}		
	}

}
