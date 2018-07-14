using System;
using NUnit.Framework;
using System.Collections.Generic;

namespace PascalsTriangle.Tests
{
    [TestFixture]
    public class KataTests
    {
        [Test]
        public void Level1()
        {
            CollectionAssert.AreEqual( new List<int> { 1 }, new Kata().PascalsTriangle(1));
        }

        [Test]
        public void Level2()
        {
            CollectionAssert.AreEqual(new List<int> { 1, 1, 1 }, new Kata().PascalsTriangle(2));
        }

        [Test]
        public void Level4()
        {
            CollectionAssert.AreEqual(new List<int> { 1, 1, 1, 1, 2, 1, 1, 3, 3, 1 }, new Kata().PascalsTriangle(4));
        }

        [Test]
        public void Level5()
        {
            CollectionAssert.AreEqual(new List<int> { 1, 1, 1, 1, 2, 1, 1, 3, 3, 1, 1, 4, 6, 4, 1 }, new Kata().PascalsTriangle(5));
        }
    }
}