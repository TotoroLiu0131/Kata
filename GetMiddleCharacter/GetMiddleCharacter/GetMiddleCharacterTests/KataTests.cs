using GetMiddleCharacter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace GetMiddleCharacter.Tests
{
    [TestFixture]
    public class KataTests
    {
        [TestCase("test", "es",Description = "test_result_should_be_es")]
        [TestCase("testing", "t", Description = "testing_result_should_be_t")]
        [TestCase("middle", "dd", Description = "middle_result_should_be_dd")]
        [TestCase("A", "A",Description = "A_result_should_be_A" )]
        public void GetMiddleCharacterTest(string input, string expect)
        {
            Assert.AreEqual(expect, Kata.GetMiddleCharacter(input));
        }
    }
}