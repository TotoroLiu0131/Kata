using NUnit.Framework;

namespace MultiplesOf3or5.Tests
{
    [TestFixture]
    public class KataTests
    {
        [TestCase(6, ExpectedResult = 8)]
        [TestCase(10, ExpectedResult = 23)]
        [TestCase(12, ExpectedResult = 33)]
        public int Test(int input)
        {
            return Kata.Solution(input);
        }
    }
}