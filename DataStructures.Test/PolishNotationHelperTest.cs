using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructures.Test
{
    using DataStructures.PolishNotation;

    [TestClass]
    public class PolishNotationHelperTest
    {
        [TestMethod]
        public void ToPostfix()
        {
            var helper = new PolishNotationHelper();
            var eq = "x ^ y / (5 * z) + 10";
            var postfix = helper.ToPostfix(eq);
            Assert.AreEqual("xy^5z*/10+",postfix);
        }

        [TestMethod]
        public void EvaluatePostfix()
        {
            var helper = new PolishNotationHelper();
            var eq = "2 5 2 ^ * 5 2 * / 4 +";
            var resultPostfix = helper.EvaluatePostfix(eq);
            Assert.AreEqual(9, resultPostfix);

        }
    }
}
