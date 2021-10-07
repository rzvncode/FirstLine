using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLine.Interfaces
{
    public interface IPricingRule
    {
        string SKU { get; }
        double Value { get; }
        bool Evaluate(string sku, IEnumerable<string> skus);
    }
}
