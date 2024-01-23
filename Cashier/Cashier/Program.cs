namespace Cashier
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Cashier c1 = new Cashier(new Cash());
            c1.CheckOut(1000.21m);
            Cashier c2 = new Cashier(new Visa());
            c2.CheckOut(1000.21m);
            Cashier c3 = new Cashier(new MasterCard());
            c3.CheckOut(1000.21m);
            Cashier c4 = new Cashier(new InstaPay());
            c4.CheckOut(1000.21m);
         
        }
    }
      
}