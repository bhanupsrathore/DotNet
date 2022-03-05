namespace DBClientApp
{
    using Data;

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Text = "DBClientApp - " + DateTime.Now;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            using var store = new ProductStore();
            store.LoadProducts(productBindingSource);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to update this product?", "DBClientApp", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            var product = (Product) productBindingSource.Current;
            using var store = new ProductStore();
            store.UpdateProduct(product);
        }

        private void productBindingSource_PositionChanged(object sender, EventArgs e)
        {
            var product = (Product)productBindingSource.Current;
            using var store = new ProductStore();
            productOrderBindingSource.Clear();
            store.LoadOrders(product, productOrderBindingSource);
        }
    }
}