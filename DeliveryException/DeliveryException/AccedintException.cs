using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryException
{
    public class AccedintException : Exception
    {
        public string Location {  get; set; }

        public AccedintException(string location , string message) :base(message)
        {
            Location = location;
        }
    }
}
