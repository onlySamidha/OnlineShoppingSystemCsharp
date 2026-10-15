// Name: Samidha Mote
// Roll no.: 2643

// Stores shipment details and provides shipment tracking.
namespace OnlineShoppingSystem
{
    public class Shipment
    {
        private int? shipmentId;
        private string? trackingNumber;
        private DateTime? shipmentDate;
        private string? deliveryStatus;

        // Displays the shipment tracking status.
        public void TrackingShipment()
        {
            Console.WriteLine("Tracking shipment");
        }
    }
}
