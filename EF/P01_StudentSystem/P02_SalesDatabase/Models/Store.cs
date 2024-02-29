using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_SalesDatabase.Models
{
    internal class Store
    {
        public int StoreId { get; set; }

        [MinLength(80)]
        [Unicode(true)]
        public string Name { get; set; }

        public ICollection<Sale> Sales { get; set; }

    }
}
