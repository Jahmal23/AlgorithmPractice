using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercises;

namespace ExerciseTests
{
    [TestClass]
    public class AsyncFunTests
    {
        [TestMethod]
        public void ShouldRun()
        {
            var af = new AsyncFun();

            af.GetPeople();
        }
    }
}
