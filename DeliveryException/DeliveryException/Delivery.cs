namespace DeliveryException
{
    public class Delivery
    {
        public string Name { get; set; }
        public int ID { get; set;}

        public string Address { get; set; } 

        public DeliveryStatus deliveryStatus { get; set; }

        public override string ToString()
        {
            return $"{{\n   ID : {ID},\n   Customer : {Name},\n   Address : {Address},\n   Delivery Status : {deliveryStatus}\n}}";
        }
    }
}
