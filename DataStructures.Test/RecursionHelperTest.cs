using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructures.Test
{
    using DataStructures.Recursion;

    [TestClass]
    public class RecursionHelperTest
    {
        [TestMethod]
        public void SumDigits()
        {
            var helper = new CommonRecursionHelper();
            var result = helper.SumDigits(123456);
            Assert.AreEqual(21, result);
        }

        [TestMethod]
        public void ToBinary()
        {
            var helper = new CommonRecursionHelper();
            var result = helper.ToBinary(100);
            Assert.AreEqual("1100100", result);
        }

        [TestMethod]
        public void ToOctal()
        {
            var helper = new CommonRecursionHelper();
            var result = helper.ToOctal(100);
            Assert.AreEqual("144", result);
        }

        [TestMethod]
        public void ToHex()
        {
            var helper = new CommonRecursionHelper();
            var result = helper.ToHex(100);
            Assert.AreEqual("64", result);
        }

        [TestMethod]
        public void ToPower()
        {
            var helper = new CommonRecursionHelper();
            var result = helper.ToPow(5,2);
            Assert.AreEqual(25, result);
        }

        [TestMethod]
        public void FindGCD()
        {
            var helper = new CommonRecursionHelper();
            var result = helper.FindGCD(3324585, 125);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void CalculateFibonacci()
        {
            var helper = new CommonRecursionHelper();
            var result = helper.CalculateFibonacci(10);
            Assert.AreEqual(55,result);
        }


        [TestMethod]
        public void CreateFibonacciSeries()
        {
            var helper = new CommonRecursionHelper();
            var result = helper.CreateFibonacciSeries(10);
            Assert.AreEqual("0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55", result);
        }
    }
}
