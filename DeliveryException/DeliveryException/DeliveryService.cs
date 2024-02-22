using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryException
{
    internal class DeliveryService
    {
        private readonly static Random random = new Random();
        public void start(Delivery delivery) 
        {
            try
            {
                Process(delivery);
                Ship(delivery);
                Transit(delivery);
                Deliver(delivery);
            }
            catch(AccedintException ex)
            {
                Console.WriteLine($"At {ex.Location} {ex.Message}");
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine(delivery);
            }
        }

        private void Process(Delivery delivery)
        {
            FakeIt("Processing");
            if (random.Next(1, 5) == 1)
            {
                throw new InvalidDataException("unable Process");
            }
            
            delivery.deliveryStatus = DeliveryStatus.PROCESS;
        }

        private void Deliver(Delivery delivery)
        {
            FakeIt("Delivering");
            if (random.Next(1, 2) == 1)
            {
                throw new AccedintException("456 Street" , "There Accedint !!!!!!");
            }
            
            delivery.deliveryStatus = DeliveryStatus.DELIVERED;
        }

        private void Transit(Delivery delivery)
        {
            FakeIt("Transitting");
            if (random.Next(1, 5) == 1)
            {
                throw new InvalidDataException("unable transit");
            }
            delivery.deliveryStatus = DeliveryStatus.TRANSIT;
        }

        private void Ship(Delivery delivery)
        {
            FakeIt("Shipping");
            if (random.Next(1, 5) == 1)
            {
                throw new InvalidDataException("unable shipp");
            }
            delivery.deliveryStatus = DeliveryStatus.SHIPPED;
        }

        private void FakeIt(string s )
        {
            Console.Write(s);
            System.Threading.Thread.Sleep(300);
            Console.Write(".");
            System.Threading.Thread.Sleep(300);
            Console.Write(".");
            System.Threading.Thread.Sleep(300);
            Console.Write(".");
            System.Threading.Thread.Sleep(300);
            Console.Write(".");
            System.Threading.Thread.Sleep(300);
            Console.Write(".");
            System.Threading.Thread.Sleep(300);
            Console.Write(".");
            System.Threading.Thread.Sleep(300);
            Console.Write(".\n");
        }
    }
}
