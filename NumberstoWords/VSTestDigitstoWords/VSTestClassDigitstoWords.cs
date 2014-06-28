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
            Assert.AreEqual("Five hundred and sixty four", digitsWords.AmountInWords("564", 1));
        }
        [TestMethod]
        public void TestDigitstoWords2()
        {
            DigitstoWords digitsWords = new DigitstoWords();
            Assert.AreEqual("Eight thousand five hundred and sixty four", digitsWords.AmountInWords("8564", 1));
        }
    }
}
