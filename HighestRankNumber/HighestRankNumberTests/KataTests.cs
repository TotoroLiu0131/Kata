using HighestRankNumber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;


namespace HighestRankNumber.Tests
{
    [TestFixture]
    public class KataTests
    {
        [Test]
        public void test_highest_rank_result_should_be_12()
        {
            var actual = Kata.HighestRank(new List<int> {12, 10, 8, 12, 7, 6, 4, 10, 12});
            var expect = 12;

            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void test_highest_rank_result_should_be_12_when_others_has_same_counts()
        {
            var actual = Kata.HighestRank(new List<int> { 12, 10, 8, 12, 7, 6, 4, 10, 12, 10 });
            var expect = 12;

            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void test_highest_rank_result_should_be_3()
        {
            var actual = Kata.HighestRank(new List<int> { 12, 10, 8, 8, 3, 3, 3, 3, 2, 4, 10, 12, 10 });
            var expect = 3;

            Assert.AreEqual(expect, actual);
        }
    }
}