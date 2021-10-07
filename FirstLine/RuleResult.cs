using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLine
{
    public class RuleResult
    {
        private string sku;
        public string Sku { get { return sku; } }

        private double value;
        public double Value { get { return value; } }

        public RuleResult(string sku, double value)
        {
            this.sku = sku;
            this.value = value;
        }
    }
}
