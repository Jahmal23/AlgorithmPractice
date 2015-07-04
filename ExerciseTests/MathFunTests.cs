using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercises;

namespace ExerciseTests
{
    [TestClass]
    public class MathFunTests
    {
        [TestMethod]
        public void ShouldPerformSimpleCalculation()
        {
            int result = MathFun.PerformPolish("+-678");
            Assert.AreEqual(7, result, "Simple Calc Failed");
        }

        [TestMethod]
        public void ShouldPerformLongerCalculation()
        {
            int result = MathFun.PerformPolish("x+--59381");
            Assert.AreEqual(1, result, "Longer Calc Failed");
        }

        [TestMethod]
        public void ShouldPerformSuperLongCalculation()
        {
            int result = MathFun.PerformPolish("x++-x+-12345678");
            Assert.AreEqual(128, result, "Super Long Calc Failed");
        }

        [TestMethod]
        public void ShouldNotPerformUnbalancedCalculation()
        {
            int result = MathFun.PerformPolish("+-45");
            Assert.AreEqual(-1, result, "Unbalanced Calc Failed");

            int result2 = MathFun.PerformPolish("+--1");
            Assert.AreEqual(-1, result2, "Unbalanced Calc 2 Failed");

            int result3 = MathFun.PerformPolish("+-1111111111111");
            Assert.AreEqual(-1, result3, "Unbalanced Calc 3 Failed");
        }

        [TestMethod]
        public void ShouldNotPerformNullCalculation()
        {
            int result = MathFun.PerformPolish(null);
            Assert.AreEqual(-1, result, "Null Calc Failed");
        }

        [TestMethod]
        public void ShouldNotPerformEmptyCalculation()
        {
            int result = MathFun.PerformPolish(string.Empty);
            Assert.AreEqual(-1, result, "Empty Calc Failed");

            int result2 = MathFun.PerformPolish("      ");
            Assert.AreEqual(-1, result, "Empty Calc 2 Failed");
        }

    }
}
