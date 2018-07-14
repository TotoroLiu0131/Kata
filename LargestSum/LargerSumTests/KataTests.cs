using NUnit.Framework;

namespace LargestSum.Tests
{
    [TestFixture]
    public class KataTests
    {
        [TestCase(new[] { -1, -2, -3 }, 0)]
        [TestCase(new int[0],  0)]
        [TestCase(new[] { 1, 2, 3, 4 }, 10)]
        [TestCase(new[] { 31, -41, 59, 26, -53, 58, 97, -93, -23, 84 }, 187)]

        public void LargestSumTest(int[] arr, int expect)
        {
            var actual = Kata.LargestSum(arr);

            Assert.AreEqual(expect, actual);
        }
    }
}