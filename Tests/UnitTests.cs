using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GithubActionsLab
{
    [TestClass]
    public class MathTests
    {
        [TestMethod]
        public void Add_Valid_Wilcoxen()
        {
            Assert.AreEqual(3, Program.Add("1", "2"));
            Assert.AreEqual(5, Program.Add("3", "2"));
            Assert.AreEqual(12, Program.Add("5", "7"));
        }

        [TestMethod]
        public void Add_Invalid_Wilcoxen()
        {
            Assert.ThrowsException<FormatException>(() => Program.Add("1", "a"));
            Assert.ThrowsException<FormatException>(() => Program.Add("a", "1"));
            Assert.ThrowsException<FormatException>(() => Program.Add("a", "a"));
        }

        [TestMethod]
        public void Add_Null_Wilcoxen()
        {
            Assert.ThrowsException<ArgumentNullException>(() => Program.Add("1", null));
            Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, "1"));
            Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, null));
        }

        [TestMethod]
        public void Subtract_Valid_Wilcoxen()
        {
            Assert.AreEqual(2, Program.Subtract("5", "3"));
            Assert.AreEqual(0, Program.Subtract("2", "2"));
            Assert.AreEqual(-1, Program.Subtract("4", "5"));
        }

        [TestMethod]
        public void Multiply_Valid_Wilcoxen()
        {
            Assert.AreEqual(6, Program.Multiply("2", "3"));
            Assert.AreEqual(0, Program.Multiply("0", "5"));
            Assert.AreEqual(-15, Program.Multiply("-3", "5"));
        }

        [TestMethod]
        public void Divide_Valid_Wilcoxen()
        {
            Assert.AreEqual(2, Program.Divide("6", "3"));
            Assert.AreEqual(0.5, Program.Divide("1", "2"));
            Assert.AreEqual(-4, Program.Divide("-8", "2"));
        }
    }
}
