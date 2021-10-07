using FirstLine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLine
{
    public class CartService : ICartService
    {
        private List<IPricingRule> rules;

        private List<string> skus;
        private List<RuleResult> results;

        public double GetTotal()
        {
            return results.Sum(r => r.Value);
        }

        public CartService(List<IPricingRule> rules)
        {
            this.rules = rules;

            this.skus = new List<string>();
            results = new List<RuleResult>();
        }
        public void Remove(Product item)
        {
            skus.Remove(item.SKU);
            var result = rules.Where(r => r.SKU == item.SKU).Where(r => r.Evaluate(item.SKU, skus)).Select(r => new RuleResult(r.SKU, r.Value));
            results = results.Except(result).ToList();
        }

        public void Add(Product item)
        {
            skus.Add(item.SKU);
            var result = rules.Where(r => r.SKU == item.SKU).Where(r => r.Evaluate(item.SKU, skus)).Select(r => new RuleResult(r.SKU, r.Value));
            results.AddRange(result);
        }
    }
}
