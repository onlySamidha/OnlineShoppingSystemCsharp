// Name: Samidha Mote
// Roll no.: 2643

// Stores payment details and processes a payment.
namespace OnlineShoppingSystem
{
    public class Payment
    {
        private int? paymentId;
        private string? paymentMethod;
        private decimal? amount;
        private string? paymentStatus;

        // Displays the payment result, as in the original Python program.
        public void MakePayment()
        {
            Console.WriteLine("Payment Successful");
        }
    }
}
