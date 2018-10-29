using System.Collections.Generic;
using NewCart.Models;

namespace NewCart.Company.Interfaces
{
   public interface ICartDiscountRule
    {
        bool IsEligible(IEnumerable<CartItem> items);
        decimal Discount(IEnumerable<CartItem> items);
    }
}
