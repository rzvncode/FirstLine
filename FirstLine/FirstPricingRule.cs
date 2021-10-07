using FirstLine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLine
{
    public class FirstPricingRule : IPricingRule
    {
        private string sku;
        public string SKU { get { return sku; } }

        private double value;
        public double Value { get { return value; } }

        private int count;
        public bool Evaluate(string sku, IEnumerable<string> skus)
        {
            return skus.Count(s => s == sku) % count == 0;
        }
        public FirstPricingRule(string sku, double value, int count)
        {
            this.sku = sku;
            this.value = value;
            this.count = count;
        }
    }
}
