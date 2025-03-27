using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GithubActionsLab
{
    [TestClass]
    public class MathTests
    {
        [TestMethod]
        public void Add_Valid()
        {
            Assert.AreEqual(3, Program.Add("1", "2"));
            Assert.AreEqual(5, Program.Add("3", "2"));
            Assert.AreEqual(12, Program.Add("5", "7"));
        }

        [TestMethod]
        public void Add_Invalid()
        {
            Assert.ThrowsException<FormatException>(() => Program.Add("1", "a"));
            Assert.ThrowsException<FormatException>(() => Program.Add("a", "1"));
            Assert.ThrowsException<FormatException>(() => Program.Add("a", "a"));
        }

        [TestMethod]
        public void Add_Null()
        {
            Assert.ThrowsException<ArgumentNullException>(() => Program.Add("1", null));
            Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, "1"));
            Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, null));
        }

        [TestMethod]
        public void Power_Valid()
        {
            Assert.AreEqual(8, Program.Power("2", "3"));
            Assert.AreEqual(1, Program.Power("5", "0"));
            Assert.AreEqual(10000, Program.Power("10", "4"));
        }

        [TestMethod]
        public void Power_Invalid()
        {
            Assert.ThrowsException<FormatException>(() => Program.Power("a", "3"));
            Assert.ThrowsException<FormatException>(() => Program.Power("2", "b"));
            Assert.ThrowsException<FormatException>(() => Program.Power("x", "y"));
        }

        [TestMethod]
        public void Power_Null()
        {
            Assert.ThrowsException<ArgumentNullException>(() => Program.Power(null, "3"));
            Assert.ThrowsException<ArgumentNullException>(() => Program.Power("2", null));
            Assert.ThrowsException<ArgumentNullException>(() => Program.Power(null, null));
        }
    }
}
