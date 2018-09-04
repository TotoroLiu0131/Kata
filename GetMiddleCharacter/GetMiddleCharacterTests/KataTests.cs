using NUnit.Framework;

namespace GetMiddleCharacter.Tests
{
    [TestFixture]
    public class KataTests
    {
        [TestCase("test", ExpectedResult = "es", TestName = "input_test_should_return_es")]
        [TestCase("testing", ExpectedResult = "t", TestName = "input_testing_should_return_t")]
        [TestCase("A", ExpectedResult = "A", TestName = "input_A_should_return_A")]
        public string GetMiddleCharacterTest(string input)
        {
            return new Kata().GetMiddleCharacter(input);
        }
    }
}