using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlayWithTwoStrings;

namespace PlayWithTwoStrings.Tests
{
    [TestClass()]
    public class KataTests
    {
        [TestMethod]
        public void should_be_ABABbababa()
        {
            var expected = "ABABbababa";
            var actual = Kata.CombinTwoWorkOnStrings("abab", "bababa");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void should_be_abcDeFGtrzWDEFGgGFhjkWqE()
        {
            var expected = "abcDeFGtrzWDEFGgGFhjkWqE";
            var actual = Kata.CombinTwoWorkOnStrings("abcdeFgtrzw", "defgGgfhjkwqe");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void should_be_abcDEfgDEFGg()
        {
            var expected = "abcDEfgDEFGg";
            var actual = Kata.CombinTwoWorkOnStrings("abcdeFg", "defgG");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void should_be_abCCde()
        {
            var expected = "abCCde";
            var actual = Kata.CombinTwoWorkOnStrings("abc", "cde");

            Assert.AreEqual(expected, actual);
        }
    }
}