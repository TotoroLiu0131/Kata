using Microsoft.VisualStudio.TestTools.UnitTesting;
using RunnersMeetings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunnersMeetingsTests
{
    [TestClass()]
    public class KataTests
    {
        [TestMethod()]
        public void should_be_3()
        {
            var expect = 3;
            var actual = Kata.RunnersMeetings(new[] { 1, 4, 2 }, new[] { 27, 18, 24 });

            Assert.AreEqual(expect,actual);
        }

        [TestMethod]
        public void should_be_default()
        {
            var expect = -1;
            var actual = Kata.RunnersMeetings(new[] { 1, 4, 2 }, new[] { 27, 18, 30 });

            Assert.AreEqual(expect, actual);
        }
    }
}