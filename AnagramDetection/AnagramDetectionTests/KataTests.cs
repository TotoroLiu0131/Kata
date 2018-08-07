using AnagramDetection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace AnagramDetectionTests
{
    [TestFixture]
    public class KataTests
    {
        [TestCase("foefet", "toffee",  true)]
        [TestCase("Buckethead", "DeathCubeK", true)]
        [TestCase("Twoo", "Woot", true)]
        [TestCase("apple", "pale", false)]
        public void IsAnagramTest(string test, string original, bool expect)
        {
            var actual =  Kata.IsAnagram(test, original);


            Assert.AreEqual(expect,actual);
        }
    }
}