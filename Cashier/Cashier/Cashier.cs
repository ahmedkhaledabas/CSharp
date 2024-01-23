namespace Cashier
{
    class Cashier
    {
        private IPayment _payment;

        public Cashier(IPayment payment)
        {
            _payment = payment;
        }

        public void CheckOut(decimal amount)
        {
            _payment.Pay(amount);
        }
    }
      
}