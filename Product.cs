// Name: Samidha Mote
// Roll no.: 2643

// Represents a product available in the online shopping system.
namespace OnlineShoppingSystem
{
    public class Product
    {
        private int? productId;
        private string? name;
        private decimal? price;
        private int? stock;

        // Sets and returns the product ID.
        public void SetProductId(int? productId) { this.productId = productId; }
        public int? GetProductId() { return productId; }

        // Sets and returns the product name.
        public void SetName(string? name) { this.name = name; }
        public string? GetName() { return name; }

        // Sets and returns the product price.
        public void SetPrice(decimal? price) { this.price = price; }
        public decimal? GetPrice() { return price; }

        // Sets and returns the available stock.
        public void SetStock(int? stock) { this.stock = stock; }
        public int? GetStock() { return stock; }

        // Updates the product stock (placeholder behavior from the original code).
        public void UpdateStock()
        {
            Console.WriteLine("Stock updated");
        }

        // Displays product details (placeholder behavior from the original code).
        public void DisplayDetails()
        {
            Console.WriteLine("displaying product details");
        }
    }
}
