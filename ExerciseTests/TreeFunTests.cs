using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercises;

namespace ExerciseTests
{
    [TestClass]
    public class TreeFunTests
    {
        [TestMethod]
        public void ShouldCountNodes()
        {
            Tree t = new Tree();

            t.AddLetter("c");
            t.AddLetter("a");
            t.AddLetter("t");

            Assert.AreEqual(1, t.LeftNodeCount, "left node count failed");
            Assert.AreEqual(1, t.RightNodeCount, "right node count failed");
            Assert.AreEqual(3, t.NodeCount, "total node count failed");

            t.ClearNodes();

            t.AddLetter("j");
            t.AddLetter("a");
            t.AddLetter("h");
            t.AddLetter("m");
            t.AddLetter("a");
            t.AddLetter("l");
            
            Assert.AreEqual(2, t.LeftNodeCount, "left node count 2 failed");
            Assert.AreEqual(3, t.RightNodeCount, "right node count 2 failed");
            Assert.AreEqual(6, t.NodeCount, "total node count 2 failed");


            t.ClearNodes();

            t.AddLetter("t");
            t.AddLetter("i");
            t.AddLetter("g");
            t.AddLetter("e");
            t.AddLetter("r");

            Assert.AreEqual(3, t.LeftNodeCount, "left node count 3 failed");
            Assert.AreEqual(1, t.RightNodeCount, "right node count 3 failed");
            Assert.AreEqual(5, t.NodeCount, "total node count 3 failed");


        }

    }
}
