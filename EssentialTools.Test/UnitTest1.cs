using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EssentialTools.Models;

namespace EssentialTools.Test
{
    [TestClass]
    public class UnitTest1
    {
        private IDiscountHelper getTestOjbect()
        {
            return new MinimumDiscountHelper();
        }

        [TestMethod]
        public void Discount_Above_100()
        {
            // Arrage - 시나리오 설정
            IDiscountHelper target = getTestOjbect();
            decimal total = 200;

            // Act - 작업 시도
            var discountedTotal = target.ApplyDiscount(total);

            // Assert - 결과 검증
            Assert.AreEqual(total * 0.9M, discountedTotal);
        }

        [TestMethod]
        public void Discount_Above_10_100()
        {
            // Arrage - 시나리오 설정
            IDiscountHelper target = getTestOjbect();

            // Act - 작업 시도
            decimal TenDollarDiscount = target.ApplyDiscount(10);
            decimal HundredDollarDisount = target.ApplyDiscount(100);
            decimal FiftyDollarDiscount = target.ApplyDiscount(50);

            // Assert - 결과 검증
            Assert.AreEqual(5, TenDollarDiscount, "$10 discount is wrong");
            Assert.AreEqual(95, HundredDollarDisount, "$100 discount is wrong");
            Assert.AreEqual(45, FiftyDollarDiscount, "$50 discount is wrong");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Discount_Above_Negative_Total()
        {
            // Arrage - 시나리오 설정
            IDiscountHelper target = getTestOjbect();

            // Act - 작업 시도
            target.ApplyDiscount(-1);
        }
    }
}
