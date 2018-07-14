using NUnit.Framework;



namespace SortTheOdd.Tests
{
    [TestFixture]
    public class KataTests
    {
        [TestCase(new[] { 5, 3, 2, 8, 1, 4 } , new[] { 1, 3, 2, 8, 5, 4 })]
        [TestCase(new[] { 5, 3, 1, 8, 0 }, new[] { 1, 3, 5, 8, 0 })]
        [TestCase(new int[] { }, new int[] { })]
        public void BasicTests(int[] test, int[] expect)
        {
            var actual = new Kata(test).SortArray();

            Assert.AreEqual(expect, actual);
        }
    }
}
