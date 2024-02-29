using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_SalesDatabase.Models
{
    internal class Customer
    {
        public int CustomerId { get; set; }

        [MinLength(100)]
        [Unicode(true)]
        public string Name { get; set; }

        [MinLength(80)]
        [Unicode(false)]
        public string Email { get; set; }

        public string CreaditCardNumber { get; set; }

        public ICollection<Sale> Sales { get; set; }

    }
}
