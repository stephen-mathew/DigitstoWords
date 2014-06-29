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
            //long intAmount = 564;
            //long nSet;
            //nSet = ((intAmount.ToString().Trim().Length / 3) > (Convert.ToInt64(intAmount.ToString().Trim().Length / 3)) ?
            //            Convert.ToInt64(intAmount.ToString().Trim().Length / 3) + 1 : Convert.ToInt64(intAmount.ToString().Trim().Length / 3));
            Assert.AreEqual("Five Hundred and Sixty-Four", digitsWords.AmountInWords("564", null, -1));
        }
        [TestMethod]
        public void TestDigitstoWords2()
        {
            DigitstoWords digitsWords = new DigitstoWords();
            //long intAmount = 8564;
            //long nSet;
            //nSet = ((intAmount.ToString().Trim().Length / 3) > (Convert.ToInt64(intAmount.ToString().Trim().Length / 3)) ?
            //            Convert.ToInt64(intAmount.ToString().Trim().Length / 3) + 1 : Convert.ToInt64(intAmount.ToString().Trim().Length / 3));
            Assert.AreEqual("Eight Thousand Five Hundred and Sixty-Four", digitsWords.AmountInWords("8564", null, -1));
        }

        [TestMethod]
        public void TestDigitstoWords3()
        {
            DigitstoWords digitsWords = new DigitstoWords();
            //long intAmount = 7298564;
            //long nSet;
            //nSet = ((intAmount.ToString().Trim().Length / 3) > (Convert.ToInt64(intAmount.ToString().Trim().Length / 3)) ?
            //            Convert.ToInt64(intAmount.ToString().Trim().Length / 3) + 1 : Convert.ToInt64(intAmount.ToString().Trim().Length / 3));
            Assert.AreEqual("Seven Million Two Hundred and Ninety-Eight Thousand Five Hundred and Sixty-Four", digitsWords.AmountInWords("7298564", null, -1));
        }

        [TestMethod]
        public void TestDigitstoWords4()
        {
            DigitstoWords digitsWords = new DigitstoWords();
            //long intAmount = 64;
            //long nSet;
            //nSet = ((intAmount.ToString().Trim().Length / 3) > (Convert.ToInt64(intAmount.ToString().Trim().Length / 3)) ?
            //            Convert.ToInt64(intAmount.ToString().Trim().Length / 3) + 1 : Convert.ToInt64(intAmount.ToString().Trim().Length / 3));
            Assert.AreEqual("Sixty-Four", digitsWords.AmountInWords("64", null, -1));
        }
    }
}
