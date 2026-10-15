// Name: Samidha Mote
// Roll no.: 2643

// Represents an order placed by a customer.
namespace OnlineShoppingSystem
{
    public class Order
    {
        private int? orderId;
        private decimal? totalAmount;
        private DateTime? orderDate;
        private string? status;

        // Sets and returns the order ID.
        public void SetOrderId(int? orderId) { this.orderId = orderId; }
        public int? GetOrderId() { return orderId; }

        // Sets and returns the order date.
        public void SetOrderDate(DateTime? orderDate) { this.orderDate = orderDate; }
        public DateTime? GetOrderDate() { return orderDate; }

        // Sets and returns the total order amount.
        public void SetTotalAmount(decimal? totalAmount) { this.totalAmount = totalAmount; }
        public decimal? GetTotalAmount() { return totalAmount; }

        // Sets and returns the current order status.
        public void SetStatus(string? status) { this.status = status; }
        public string? GetStatus() { return status; }

        // Confirms the customer's order.
        public void ConfirmOrder()
        {
            Console.WriteLine("order has been confirmed");
        }

        // Cancels the customer's order.
        public void CancelOrder()
        {
            Console.WriteLine("order has been cancelled");
        }
    }
}
