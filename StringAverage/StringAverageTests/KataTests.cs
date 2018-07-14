using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringAverage;

namespace StringAverageTests
{
    [TestClass]
    public class KataTests
    {
        [TestMethod]
        public void NormalTest()
        {
            Assert.AreEqual("four", Kata.StringAverage("zero nine five two"));
            Assert.AreEqual("three", Kata.StringAverage("four six two three"));
            Assert.AreEqual("three", Kata.StringAverage("one two three four five"));
            Assert.AreEqual("four", Kata.StringAverage("five four"));
            Assert.AreEqual("zero", Kata.StringAverage("zero zero zero zero zero"));
            Assert.AreEqual("two", Kata.StringAverage("one one eight one"));
        }

        [TestMethod]
        public void InputEmpty_OutputNa()
        {
            Assert.AreEqual("n/a", Kata.StringAverage(""));
        }

        [TestMethod]
        public void InputOverNine_OutputNa()
        {
            Assert.AreEqual("n/a", Kata.StringAverage("ten"));
            Assert.AreEqual("n/a", Kata.StringAverage("twenty"));
        }
    }
}
