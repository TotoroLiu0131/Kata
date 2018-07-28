using NUnit.Framework;

namespace MiddleCharacter.Tests
{
    [TestFixture]
    public class KataTests
    {
        [TestCase("test", "es", Description = "test_result_should_be_es")]
        [TestCase("testing", "t", Description = "testing_result_should_be_t")]
        [TestCase("middle", "dd", Description = "middle_result_should_be_dd")]
        [TestCase("A", "A", Description = "A_result_should_be_A")]
        public void GetMiddleCharacterTest(string input, string expect)
        {
            Assert.AreEqual(expect, Kata.GetMiddleCharacter(input));
        }
    }
}