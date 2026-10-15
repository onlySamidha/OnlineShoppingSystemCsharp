// Name: Samidha Mote
// Roll no.: 2643

// Stores customer details and provides customer-related operations.
namespace OnlineShoppingSystem
{
    public class Customer
    {
        // Private fields demonstrate encapsulation.
        private int? customerId;
        private string? name;
        private string? email;
        private string? phone;
        private string? address;

        // Sets and returns the customer ID.
        public void SetCustomerId(int? customerId) { this.customerId = customerId; }
        public int? GetCustomerId() { return customerId; }

        // Sets and returns the customer's name.
        public void SetName(string? name) { this.name = name; }
        public string? GetName() { return name; }

        // Sets and returns the customer's email address.
        public void SetEmail(string? email) { this.email = email; }
        public string? GetEmail() { return email; }

        // Sets and returns the customer's phone number.
        public void SetPhone(string? phone) { this.phone = phone; }
        public string? GetPhone() { return phone; }

        // Sets and returns the customer's address.
        public void SetAddress(string? address) { this.address = address; }
        public string? GetAddress() { return address; }

        // Logs the customer into the system.
        public void Login()
        {
            Console.WriteLine("Customer has logged in.");
        }

        // Registers a new customer.
        public void RegisterCustomer()
        {
            Console.WriteLine("Customer has registered.");
        }

        // Places an order for the customer.
        public void PlaceOrder()
        {
            Console.WriteLine("Order has been placed.");
        }
    }
}
