using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace production.Model
{
    internal class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }

        public DateTime Created {  get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public int Counter { get; set; }
        public string Email { get; set; }

        public string City { get; set; }

        public string Street { get; set; }

        public string? State { get; set; }
        [NotMapped]
        public string ZipCode { get; set; }
    }
}
