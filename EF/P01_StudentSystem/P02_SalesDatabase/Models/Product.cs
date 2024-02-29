using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_SalesDatabase.Models
{
    internal class Product
    {
        public int ProductId { get; set; }

        [MinLength(100)]
        [Unicode(true)]
        public string Name { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        [MinLength(250)]
        public string Description { get; set; }
        public ICollection<Sale> Sales { get; set; }

    }
}
