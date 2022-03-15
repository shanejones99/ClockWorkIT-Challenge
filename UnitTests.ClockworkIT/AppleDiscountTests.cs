using ClockWorkIT_Challenge;
using ClockWorkIT_Challenge.Discounts;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.ClockworkIT
{
    [TestClass]
    public class AppleDiscountTests

    {
        [TestMethod]
        public void AppleDiscountTest_NoDiscountIsAppliedWhenThereAreNoApples_ReturnsZero()
        {
            var appleDiscount = new AppleDiscount();

            double discount = AppleDiscount.CalculateAppleDiscount(0);
           
            Assert.AreEqual(0, discount);
        }

        [TestMethod]
        public void AppleDiscountTest_DiscountAppliedToOneApplesProduct_Returns10PercentDiscount()
        {
            var appleDiscount = new AppleDiscount();

            double discount = AppleDiscount.CalculateAppleDiscount(1);

            Assert.AreEqual(0.10, discount);
        }

        [TestMethod]
        public void AppleDiscountTest_DiscountCanBeAppliedToMultipleApplesProduct_Returns10PercentDiscount()
        {
            var appleDiscount = new AppleDiscount();

            double discount = AppleDiscount.CalculateAppleDiscount(10);

            Assert.AreEqual(1, discount);
        }
    }
}
