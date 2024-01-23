namespace Cashier
{
    class MasterCard : IPayment
    {
        void IPayment.Pay(decimal amount)
        {
            Console.WriteLine($"MasterCard Payment : {amount}");
        }
    }
      
}