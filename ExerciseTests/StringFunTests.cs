using System;
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
            Assert.AreEqual("J:1a:2h:1m:1l:1",StringFun.GetOccurrencesEachChar("Jahmal"), "Test for Jahmal Failed");
            Assert.AreEqual("N:1a:3t:1s:1h:1",StringFun.GetOccurrencesEachChar("Natasha"), "Test for Natasha Failed");
        }

        [TestMethod]
        public void ShouldGetOccurrencesOnBadInput()
        {
            Assert.AreEqual("",StringFun.GetOccurrencesEachChar(""),"Empty String Test Failed");
            Assert.AreEqual(StringFun.GetOccurrencesEachChar(null), "", "Null String Test Failed");
        }

        [TestMethod]
        public void ShouldRemoveOccurrences()
        {
            Assert.AreEqual("Jhml",StringFun.RemoveOccurrences("Jahmal",'a'), "Test for Jahmal Failed");
            Assert.AreEqual("atasha",StringFun.RemoveOccurrences("Natasha",'N'),"Test for Natasha Failed");
        }

        [TestMethod]
        public void ShouldRemoveOccurrencesOnBadInput()
        {
            Assert.AreEqual("",StringFun.RemoveOccurrences("", 'a'), "Empty String Test Failed");
            Assert.AreEqual(StringFun.RemoveOccurrences("Joe", 'z'), "Joe", "Missing char Test Failed");
            Assert.AreEqual("",StringFun.RemoveOccurrences(null, 'z'), "Null String Test Failed");
        }

    }
}
