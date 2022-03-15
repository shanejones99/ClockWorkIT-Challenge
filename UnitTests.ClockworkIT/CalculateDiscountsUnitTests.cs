using ClockWorkIT_Challenge;
using ClockWorkIT_Challenge.Discounts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTests.ClockworkIT
{
    [TestClass]
    class CalculateDiscountsUnitTests
    {
        [TestMethod]
        public void AppleDiscountTest_CheckNoDiscountsAreAppliedWhenDealConditionsNotMet_Returns0()
        {
            List<BasketItem> basket = new List<BasketItem>();
            basket.Add(new BasketItem(1, 0.65, "Soup"));
            double calculate = CalculateDiscounts.Calculate(basket);
            Assert.AreEqual(calculate, 0);
        }
        [TestMethod]
        public void AppleDiscountTest_CheckAppleDiscountsAreAppliedWhenApplesAreInBasket_Returns10PercentDiscount()
        {
            List<BasketItem> basket = new List<BasketItem>();
            basket.Add(new BasketItem(4, 1.00, "Apple"));
            double calculate = CalculateDiscounts.Calculate(basket);
            Assert.AreEqual(calculate, 0.10);
        }

        [TestMethod]
        public void AppleDiscountTest_CheckDiscountIsAppliedToMoreThanOneApplesProduct_Returns10PercentDiscount()
        {
            List<BasketItem> basket = new List<BasketItem>();
            basket.Add(new BasketItem(4, 1.00, "Apple"));
            basket.Add(new BasketItem(4, 1.00, "Apple"));

            double calculate = CalculateDiscounts.Calculate(basket);
            Assert.AreEqual(calculate, 0.20);
        }

        [TestMethod]
        public void AppleDiscountTest_CheckDiscountIsAppliedToBreadWhenTwoTinsOfSoupAreInBasket_Returns50PercentDiscountOnBread()
        {
            List<BasketItem> basket = new List<BasketItem>();
            basket.Add(new BasketItem(1, 0.65, "Soup"));
            basket.Add(new BasketItem(1, 0.65, "Soup"));
            basket.Add(new BasketItem(2, 0.80, "Bread"));

            double calculate = CalculateDiscounts.Calculate(basket);
            Assert.AreEqual(calculate, 0.40);
        }
        [TestMethod]
        public void AppleDiscountTest_CheckDiscountIsAppliedToCorrectNumberOfBread_Returns50PercentDiscountOnBread()
        {
            List<BasketItem> basket = new List<BasketItem>();
            basket.Add(new BasketItem(1, 0.65, "Soup"));
            basket.Add(new BasketItem(1, 0.65, "Soup"));
            basket.Add(new BasketItem(2, 0.80, "Bread"));
            basket.Add(new BasketItem(2, 0.80, "Bread"));
            double calculate = CalculateDiscounts.Calculate(basket);
            Assert.AreEqual(calculate, 0.40);
        }
        [TestMethod]
        public void AppleDiscountTest_CheckDiscountCanApplyToMultipleBreadWhenDiscountConditionsAreMet_Returns50PercentDiscountOnBread()
        {
            List<BasketItem> basket = new List<BasketItem>();
            basket.Add(new BasketItem(1, 0.65, "Soup"));
            basket.Add(new BasketItem(1, 0.65, "Soup"));
            basket.Add(new BasketItem(2, 0.80, "Bread"));
            basket.Add(new BasketItem(2, 0.80, "Bread"));
            basket.Add(new BasketItem(1, 0.65, "Soup"));
            basket.Add(new BasketItem(1, 0.65, "Soup"));
            double calculate = CalculateDiscounts.Calculate(basket);
            Assert.AreEqual(calculate, 0.80);
        }
        [TestMethod]
        public void AppleDiscountTest_CheckDiscountsAreAppliedToMultipleDeals_Returns50PercentDiscountOnBreadAnd10PercentOnApples()
        {
            List<BasketItem> basket = new List<BasketItem>();
            basket.Add(new BasketItem(1, 0.65, "Soup"));
            basket.Add(new BasketItem(1, 0.65, "Soup"));
            basket.Add(new BasketItem(2, 0.80, "Bread"));
            basket.Add(new BasketItem(2, 0.80, "Apples"));
            double calculate = CalculateDiscounts.Calculate(basket);
            Assert.AreEqual(calculate, 0.50);
        }
    }
}
