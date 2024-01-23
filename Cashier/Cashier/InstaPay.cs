namespace Cashier
{
    class InstaPay : IPayment
    {
        void IPayment.Pay(decimal amount)
        {
            Console.WriteLine($"InstaPay Payment : {amount}");
        }
    }
      
}