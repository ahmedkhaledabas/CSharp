namespace DeliveryException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var deliveryService = new DeliveryService();
            
            var delivery = new Delivery() {ID = 1,Name = "Ahmed",Address = "123 Street"};
            deliveryService.start(delivery);
        }
    }
}
