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
            Assert.AreEqual(result, 7, "Simple Calc Failed");
        }

        [TestMethod]
        public void ShouldPerformLongerCalculation()
        {
            int result = MathFun.PerformPolish("x+--59381");
            Assert.AreEqual(result, 1, "Longer Calc Failed");
        }

        [TestMethod]
        public void ShouldPerformSuperLongCalculation()
        {
            int result = MathFun.PerformPolish("x++-x+-12345678");
            Assert.AreEqual(result, 128, "Super Long Calc Failed");
        }

        [TestMethod]
        public void ShouldNotPerformUnbalancedCalculation()
        {
            int result = MathFun.PerformPolish("+-45");
            Assert.AreEqual(result, -1, "Unbalanced Calc Failed");
        }

        [TestMethod]
        public void ShouldNotPerformNullCalculation()
        {
            int result = MathFun.PerformPolish(null);
            Assert.AreEqual(result, -1, "Null Calc Failed");
        }





    }
}
