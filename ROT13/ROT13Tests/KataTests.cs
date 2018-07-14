using Microsoft.VisualStudio.TestTools.UnitTesting;
using ROT13;

namespace ROT13Tests
{
    [TestClass]
    public class KataTests
    {
        [TestMethod]
        public void sould_be_correct()
        {
            Assert.AreEqual("ROT13 example.", Kata.Rot13("EBG13 rknzcyr."));
            Assert.AreEqual("EBG13 rknzcyr.", Kata.Rot13("ROT13 example."));
            Assert.AreEqual("Guvf vf zl svefg EBG13 rkprepvfr!", Kata.Rot13("This is my first ROT13 excercise!"));
            Assert.AreEqual("This is my first ROT13 excercise!", Kata.Rot13("Guvf vf zl svefg EBG13 rkprepvfr!"));
            Assert.AreEqual("ABCDEFGHIJKLMNOPQRSTUVWXYZ!!", Kata.Rot13("NOPQRSTUVWXYZABCDEFGHIJKLM!!"));
        }
    }
}