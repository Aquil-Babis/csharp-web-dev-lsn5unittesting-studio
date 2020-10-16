using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.

        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(true, true);
        }
        [TestMethod]
        public void OnlyBracketReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }
        [TestMethod]
        public void NoBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(""));
        }
        [TestMethod]
        public void BracketsAroundOtherCharactersReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[LanchCode]"));
        }
        [TestMethod]
        public void BracketsMidStringReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("Lanch[Code]"));
        }
        [TestMethod]
        public void BracketsBeforeString()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]LaunchCode"));
        }
        [TestMethod]
        public void SoloBracketReturnsFalses()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("["));
        }
        //Test that Odd number of brackets returns false.
        [TestMethod]
        public void OddNumberOfBracketsReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[LanchCode"));
        } 
        //Test that wrong facing brackets returns false.
        [TestMethod]
        public void WrongFacingBracketsReturnFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]["));
        }
        [TestMethod]
        public void WrongFacingBracketsInStringReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("Launch][Code"));
        }
        [TestMethod]
        public void NestedBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[Launch[Code]]"));
        }
        [TestMethod]
        public void MismatchedBracketsShouldReturnFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[)"));
        }
        [TestMethod]
        public void MultipleBracketTypesUsedCorrectlyReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[Launch(Code){Uses Codes}]"));
        }
    }
}
