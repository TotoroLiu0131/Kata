using CarParkEscape;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CarParkEscapeTests
{
    [TestFixture]
    public class KataTests
    {
        [Test]
        public void should_be_L4_D1_R4()
        {
            var carpark = new[] { new[]{ 1, 0, 0, 0, 2 },
                                  new[]{ 0, 0, 0, 0, 0 } };

            var actual = Kata.Escape(carpark);
            var expect = new[] { "L4", "D1", "R4" };
            
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void should_be_R3_D2_R1()
        {
            var carpark = new[] {new[] { 2, 0, 0, 1, 0 },
                                 new[] { 0, 0, 0, 1, 0 },
                                 new[] { 0, 0, 0, 0, 0 } };

            var actual = Kata.Escape(carpark);
            var expect = new[] { "R3", "D2", "R1" };

            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void should_be_R3_D3()
        {
            var carpark = new[]  { new[]{ 0, 2, 0, 0, 1 },
                                   new[]{ 0, 0, 0, 0, 1 },
                                   new[] { 0, 0, 0, 0, 1 },
                                   new[] { 0, 0, 0, 0, 0 } };

            var actual = Kata.Escape(carpark);
            var expect = new[] { "R3", "D3"};

            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void should_be_L4_D1_R4_D1_L4_D1_R4()
        {
            var carpark = new[]   { new[]{ 1, 0, 0, 0, 2 },
                                    new[]{ 0, 0, 0, 0, 1 },
                                    new[]{ 1, 0, 0, 0, 0 },
                                    new[] { 0, 0, 0, 0, 0 } };

            var actual = Kata.Escape(carpark);
            var expect = new[] { "L4", "D1", "R4", "D1", "L4", "D1", "R4" };

            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void should_be_empty()
        {
            var carpark = new[] { new[] { 0, 0, 0, 0, 2 } };

            var actual = Kata.Escape(carpark);
            var expect = new string[] { };

            Assert.AreEqual(expect, actual);
        }
    }
}