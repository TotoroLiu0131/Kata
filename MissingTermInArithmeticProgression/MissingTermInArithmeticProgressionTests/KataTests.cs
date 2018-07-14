using MissingTermInArithmeticProgression;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;

namespace MissingTermInArithmeticProgression.Tests
{
    [TestFixture]
    public class KataTests
    {
        [TestCase(new[] {1, 3, 5, 9, 11}, ExpectedResult = 7, TestName = "test_interval_2")]
        [TestCase(new[] {1, 5, 9, 17}, ExpectedResult = 13, TestName = "test_interval_4")]
        [TestCase(new[] {17, 15, 11, 9, 7}, ExpectedResult = 13, TestName = "test_interval_-2")]
        [TestCase(new[] {1, 2, 3, 5, 6}, ExpectedResult = 4, TestName = "test_interval_1")]
        public int FindMissingTermTest(int[] input)
        {
            return Kata.FindMissingTerm(input);
        }
    }
}