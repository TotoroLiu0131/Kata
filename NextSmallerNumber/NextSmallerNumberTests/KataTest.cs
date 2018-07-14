using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NextSmallerNumber;

namespace NextSmallerNumberTests
{
    [TestClass]
    public class KataTest
    {
        [TestMethod]
        public void should_be_12()
        {
            var expect = 12;
            var actual = Kata.NextSmallerNumber(21);

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void should_be_6357()
        {
            var expect = 6375;
            var actual = Kata.NextSmallerNumber(6537);

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void should_be_5763()
        {
            var expect = 5763;
            var actual = Kata.NextSmallerNumber(6357);

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void should_be_minusone()
        {
            var expect = -1;
            var actual = Kata.NextSmallerNumber(12);

            Assert.AreEqual(expect, actual);
        }


        [TestMethod]
        public void give_1023_should_be_minusone()
        {
            var expect = -1;
            var actual = Kata.NextSmallerNumber(1023);

            Assert.AreEqual(expect, actual);
        }
    }
}
