namespace Cashier
{
    class Visa : IPayment
    {
        void IPayment.Pay(decimal amount)
        {
            Console.WriteLine($"Visa Payment : {amount}");
        }
    }
      
}