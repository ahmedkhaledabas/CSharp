using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace production.Model
{
    internal class Brand
    {
        public int BrandID { get; set; }
        public string BrandName { get; set; }

        public List<Product> Products { get; set; }
    }
}
