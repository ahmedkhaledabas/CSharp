using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace production.Model
{
    internal class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }

        public DateTime ModelYear { get; set; }

        public double ListPrice { get; set; }

        public int CategoryID { get; set; }

        public int BrandID { get; set; }
        public Category Category { get; set; }

        public Brand brand { get; set; }
    }
}
