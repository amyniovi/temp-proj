using System;
using System.Collections.Generic;

using NewCart.Models;
using NewCart.Models.Calculators;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

/*Scenarios*
 Given the basket has 1 bread, 1 butter and 1 milk when I total the basket then the total
should be £2.95
• Given the basket has 2 butter and 2 bread when I total the basket then the total should be
£3.10
• Given the basket has 4 milk when I total the basket then the total should be £3.45
• Given the basket has 2 butter, 1 bread and 8 milk when I total the basket then the total
should be £9.00 
 Here I am testing only for the scenarios above not testing in depth.
   */

namespace NewCart.Tests
{
    [TestFixture]
    public class CartDiscountTests
    {


        [SetUp]
        public void Setup()
        {
        }
        private readonly CartItem _bread = new CartItem() { Name = "bread", CostPerUnit = 1 };
        private readonly CartItem _butter = new CartItem() { Name = "butter", CostPerUnit = 0.80m };
        private readonly CartItem _milk = new CartItem() { Name = "bread", CostPerUnit = 1.15m };

        [TestCase(1, 1, 1, 2.95)]
        [Test]
        public void GetCart_GivenOneOfEach_ExpectedTotal(int breadQty, int butterQty, int milkQty, double expectedTotal)
        {
            var cart = SetUpCart(breadQty, butterQty, milkQty);
            Assert.That((decimal)expectedTotal == cart.TotalCost);
        }

        [TestCase(2, 2, 0, 3.10)]
        [Test]
        public void GetCart_Giver2Butter2Bread_ExpectedTota(int breadQty, int butterQty, int milkQty, double expectedTotal)
        {
            var cart = SetUpCart(breadQty, butterQty, milkQty);
            Assert.That((decimal)expectedTotal == cart.TotalCost);
        }

        [TestCase(0, 0, 4, 3.45)]
        [Test]
        public void GetCart_Given4Milk_ExpectedTotal(int breadQty, int butterQty, int milkQty, double expectedTotal)
        {
            var cart = SetUpCart(breadQty, butterQty, milkQty);
            Assert.That((decimal)expectedTotal == cart.TotalCost);
        }

        [TestCase(1,2,8, 9)]
        [TestCase]
        public void GetCart_Given2Butter1Bread8Milk_ExpectedTotal(int breadQty, int butterQty, int milkQty, double expectedTotal)
        {
            var cart = SetUpCart(breadQty, butterQty, milkQty);
            Assert.That((decimal)expectedTotal == cart.TotalCost);
        }

        private Cart SetUpCart(int breadQty, int butterQty, int milkQty)
        {
            var items = new List<CartItem>();
            _bread.Qty = breadQty;
            _butter.Qty = butterQty;
            _milk.Qty = milkQty;
            items.Add(_bread);
            items.Add(_butter);
            items.Add(_milk);
            var cart = new Cart(new CartDiscountCalculator()) { Items = items };
            return cart;
        }
    }
}




   
      

