using System;
using System.Collections.Generic;

/*
 * I am assumming any Item Discounts Should be Calculated by the Item itself according to the tell dont ask principle
 * Any Cart discounts would need to be calculated by the Cart on top. 
 */
namespace NewCart.Models
{
    public class CartItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal TotalItemCost => TotalPrice();
        public decimal CostPerUnit { get; set; }
        public int Qty { get; set; }
        public string Info { get; set; } = String.Empty;

        public Dictionary<string, Func<int, decimal, decimal>> DiscountRules { get; set; } = new Dictionary<string, Func<int, decimal, decimal>>();

        public CartItem()
        {
            DiscountRules.Add("milk", (qty, costPerUnit) =>
            {
                var total = qty * costPerUnit;
                var discount = Math.Floor(total / 4) * costPerUnit;
                return total - discount;
            });
        }

        private decimal TotalPrice()
        {
            var total = CostPerUnit * Qty;

            foreach (var rule in DiscountRules)
            {
                if (rule.Key == this.Name)
                    return rule.Value(this.Qty,CostPerUnit);
            }
            return total;
        }
    }
}