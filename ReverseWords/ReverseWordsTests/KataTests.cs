using NUnit.Framework;

namespace ReverseWords.Tests
{
    [TestFixture]
    public class KataTests
    {
        [TestCase("This is an example!", ExpectedResult = "sihT si na !elpmaxe", TestName = "result_should_be_sihT si na !elpmaxe")]
        [TestCase("double spaces", ExpectedResult = "elbuod secaps", TestName = "result_should_be_elbuod  secaps")]
        public string ReverseWordsTest(string input)
        {
            return Kata.ReverseWords(input);
        }
    }
}