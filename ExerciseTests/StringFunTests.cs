﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercises;


namespace ExerciseTests
{
    [TestClass]
    public class StringFunTests
    {
        [TestMethod]
        public void ShouldGetOccurrences()
        {
            Assert.AreEqual(StringFun.GetOccurrencesEachChar("Jahmal"), "J:1a:2h:1m:1l:1", "Test for Jahmal Failed");
            Assert.AreEqual(StringFun.GetOccurrencesEachChar("Natasha"), "N:1a:3t:1s:1h:1", "Test for Natasha Failed");
        }

        [TestMethod]
        public void ShouldGetOccurrencesOnBadInput()
        {
            Assert.AreEqual(StringFun.GetOccurrencesEachChar(""), "", "Empty String Test Failed");
            Assert.AreEqual(StringFun.GetOccurrencesEachChar(null), "", "Null String Test Failed");
        }
    }
}