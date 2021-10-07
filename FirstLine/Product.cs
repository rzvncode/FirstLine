using FirstLine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLine
{
    public class Product : IProduct
    {
        public string SKU { get; set; }
        public double Price { get; set; }
    }
}
