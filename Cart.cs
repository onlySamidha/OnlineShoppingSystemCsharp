// Name: Samidha Mote
// Roll no.: 2643

// Represents a customer's shopping cart.
namespace OnlineShoppingSystem
{
    public class Cart
    {
        private int? cartId;
        private DateTime? createDate;

        // Sets and returns the cart ID.
        public void SetCartId(int? cartId) { this.cartId = cartId; }
        public int? GetCartId() { return cartId; }

        // Sets and returns the cart creation date.
        public void SetCreateDate(DateTime? createDate) { this.createDate = createDate; }
        public DateTime? GetCreateDate() { return createDate; }

        // Adds an item to the cart.
        public void AddItem()
        {
            Console.WriteLine("Item added");
        }

        // Removes an item from the cart.
        public void RemoveItem()
        {
            Console.WriteLine("Item removed");
        }

        // Displays the cart.
        public void ViewCart()
        {
            Console.WriteLine("viewing");
        }
    }
}
