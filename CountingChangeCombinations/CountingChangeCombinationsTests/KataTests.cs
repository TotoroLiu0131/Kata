using System;
using NUnit.Framework;

namespace CountingChangeCombinations.Tests
{
    [TestFixture]
    public class KataTests
    {
        [TestCase(4, new[] { 1, 2 }, ExpectedResult = 3)]
        [TestCase(10, new[] { 5, 2, 3 }, ExpectedResult = 4)]
        [TestCase(11, new[] { 5, 7 }, ExpectedResult = 0)]
        public static int SimpleCase(int money, int[] coins)
        {
            return Kata.CountCombinations(money, coins);
        }
    }
}