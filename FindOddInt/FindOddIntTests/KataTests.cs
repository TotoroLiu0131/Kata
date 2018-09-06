using NUnit.Framework;

namespace FindOddInt.Tests
{
    [TestFixture]
    public class KataTests
    {
        [Test]
        public void result_should_be_5()
        {
            var input = new[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 };

            var actual = new Kata().GetOddInt(input);

            Assert.AreEqual(5, actual);
        }

        [Test]
        public void result_should_be_1()
        {
            var input = new[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5, 5, 1 };

            var actual = new Kata().GetOddInt(input);

            Assert.AreEqual(1, actual);
        }

        [Test]
        public void result_should_be_2()
        {
            var input = new[] { 1, 1, 1, 1, 3, 3, 3, 3, 2, 2, 2 };

            var actual = new Kata().GetOddInt(input);

            Assert.AreEqual(2, actual);
        }
    }
}