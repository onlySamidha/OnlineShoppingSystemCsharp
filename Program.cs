// Name: Samidha Mote
// Roll no.: 2643

// Main entry point for the Online Shopping Management System.
// Creates objects, sets sample data, retrieves data, and calls methods.
using System;
using OnlineShoppingSystem;

class Program
{
    static void Main()
    {
        // Create a customer and fill in some details using setter methods.
        Customer customer = new Customer();
        customer.SetCustomerId(10);
        customer.SetName("Samidha");
        customer.SetEmail("samidhamote04@gmail.com");

        // Create a product and set its details.
        Product product = new Product();
        product.SetProductId(1);
        product.SetName("laptop");
        product.SetPrice(67000m);

        // Create objects for the other parts of the shopping system.
        Cart cart = new Cart();
        Order order = new Order();
        Payment payment = new Payment();
        Shipment shipment = new Shipment();

        // Display details using getter methods.
        Console.WriteLine("Customer:" + customer.GetName());
        Console.WriteLine("Product:" + product.GetName());
        Console.WriteLine("price:" + product.GetPrice());

        // Demonstrate the basic shopping operations.
        customer.RegisterCustomer();
        customer.Login();
        cart.AddItem();
        order.ConfirmOrder();
        payment.MakePayment();
        shipment.TrackingShipment();
    }
}
