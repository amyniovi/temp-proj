using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Antlr.Runtime;
using Microsoft.Ajax.Utilities;
using NewCart.Company.Interfaces;

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

        //UniqueId=Username here
        public string UniqueId { get; set; }
        public bool IsCheckedOut { get; set; }
        public decimal TotalCost => _discountCalculator.CalculateDiscountedTotalPrice(Items.ToList());
        public List<CartItem> Items { get; set; }

        //public List<CartItem> Items {
            //    get
            //    {
            //        return Items
            //            .GroupBy(item => item.Name)
            //            .Select(g=>new CartItem(){Name = g.Key,Qty = g.Sum(x=>x.Qty)})
            //            .ToList();
            //    }
            //    set { Items = value; }
            //}
        }
}