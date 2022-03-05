using System.Collections.Generic;
using Microsoft.Toolkit.Mvvm.Input;
using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace RichClientApp
{
    public class MainWindowViewModel : ObservableObject
    {
        private readonly ProductModel model = new ProductModel();

        public List<Product> Products { get; private set; }

        public MainWindowViewModel()
        {
            Products = model.ReadProducts();
            _currentProduct = Products[0];
            _statusMessage = "Ready";
        }

        private Product _currentProduct;
        public Product CurrentProduct
        {
            get => _currentProduct;
            set
            {
                SetProperty(ref _currentProduct, value);
                StatusMessage = "Ready";
            }
        }

        private string _statusMessage;
        public string StatusMessage
        {
            get => _statusMessage;
            set
            {
                SetProperty(ref _statusMessage, value);
            }
        }

        public RelayCommand Update => new RelayCommand( async () => 
        {
            if (await model.WriteProduct(_currentProduct))
                StatusMessage = "Product updated successfully";
            else
                StatusMessage = "Product update failed";
        });
    }
}
