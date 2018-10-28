using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Antlr.Runtime;

//decided to use the Strategy pattern here. 
//partly using some "open-closed principle " pluralsight video that came in to mind...I think i am doing something similar :) but didnt check.
namespace NewCart.Models
{
    public class Cart
    {
        private readonly ICartDiscountCalculator _discountCalculator;

        public Cart(ICartDiscountCalculator discountCalculator)
        {
            _discountCalculator = discountCalculator;
        }

        //UniqueId=Username
        public string UniqueId { get; set; }

        public decimal TotalCost => _discountCalculator.CalculateDiscountedTotalPrice(Items);

        public List<CartItem> Items { get; set; }

    }

    public class CartDiscountCalculator : ICartDiscountCalculator
    {
        public List<CartDiscountRule> DiscountRules = new List<CartDiscountRule>();

        public CartDiscountCalculator()
        {
            DiscountRules.Add(new TwoButterRule());
        }

        public decimal CalculateDiscountedTotalPrice(IEnumerable<CartItem> items)
        {
            var total = items.Sum(item => item.TotalItemCost);
            var totalDiscount = 0;
            foreach (var rule in DiscountRules)
                if (rule.IsEligible)
                {
                    return rule.Discount;
                }

            return total - totalDiscount;

        }
    }
    public interface ICartDiscountCalculator
    {
        decimal CalculateDiscountedTotalPrice(IEnumerable<CartItem> items);
    }



    public interface ICartDiscountRule
    {
        bool IsEligible();
        decimal Discount();
    }

    public class TwoButterRule : ICartDiscountRule
    {
        private readonly IEnumerable<CartItem> _items;

        public TwoButterRule(IEnumerable<CartItem> items)
        {
            _items = items;
        }


        public bool IsEligible()
        {
            return _items.Count(item => item.Name == "butter") >= 2 && _items.Any(item => item.Name == "bread");
        }

        public decimal Discount()
        {
            throw new NotImplementedException();
        }
    }
}