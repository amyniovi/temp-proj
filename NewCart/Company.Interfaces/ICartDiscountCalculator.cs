using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewCart.Models;

namespace NewCart.Company.Interfaces
{
   public interface ICartDiscountCalculator
    {
        decimal CalculateDiscountedTotalPrice(IEnumerable<CartItem> items);
    }
}
