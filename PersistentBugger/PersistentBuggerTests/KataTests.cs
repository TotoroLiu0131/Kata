using NUnit.Framework;

namespace PersistentBugger.Tests
{
    [TestFixture]
    public class KataTests
    {
        [TestCase(39, ExpectedResult = 3, TestName = "input_39_result_should_be_3")]
        [TestCase(999, ExpectedResult = 4, TestName = "input_999_result_should_be_4")]
        [TestCase(4, ExpectedResult = 0, TestName = "input_4_result_should_be_0")]
        public long GetPersistentBuggerTest(long input)
        {
            return new Kata().GetPersistentBugger(input);
        }
    }
}