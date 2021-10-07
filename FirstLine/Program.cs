using FirstLine.Interfaces;
using System;
using System.Collections.Generic;

namespace FirstLine
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstRule = new FirstPricingRule("Big mug", 1.5, 2);

            var ruleList = new List<IPricingRule>();
            ruleList.Add(firstRule);

            var cartService = new CartService(ruleList);

            var mugProduct = new Product()
            {
                SKU ="Big mug",
                Price = 1.00,
            };

            cartService.Add(mugProduct);
            cartService.Add(mugProduct);

            var test = cartService.GetTotal();

        }
    }
}
