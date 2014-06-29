using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberstoWords;

namespace VSTestDigitstoWords
{
    [TestClass]
    public class VSTestClassDigitstoWords
    {
        [TestMethod]
        public void TestDigitstoWords1()
        {
            DigitstoWords digitsWords = new DigitstoWords();
            Assert.AreEqual("Five Hundred Sixty-Four", digitsWords.AmountInWords("564", null, -1).Trim());
        }
        [TestMethod]
        public void TestDigitstoWords2()
        {
            DigitstoWords digitsWords = new DigitstoWords();
            Assert.AreEqual("Eight Thousand Five Hundred Sixty-Four", digitsWords.AmountInWords("8564", null, -1).Trim());
        }

        [TestMethod]
        public void TestDigitstoWords3()
        {
            DigitstoWords digitsWords = new DigitstoWords();
            Assert.AreEqual("Seven Million Two Hundred Ninety-Eight Thousand Five Hundred Sixty-Four",
                digitsWords.AmountInWords("7298564", null, -1).Trim());
        }

        [TestMethod]
        public void TestDigitstoWords4()
        {
            DigitstoWords digitsWords = new DigitstoWords();
            Assert.AreEqual("Sixty-Four", digitsWords.AmountInWords("64", null, -1).Trim());
        }
    }
}
