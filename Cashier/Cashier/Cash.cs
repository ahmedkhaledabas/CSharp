namespace Cashier
{
    class Cash : IPayment
    {
        void IPayment.Pay(decimal amount)
        {
            Console.WriteLine($"Cash Payment : {amount}");
        }
    }
      
}