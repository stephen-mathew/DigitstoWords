using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberstoWords
{
    public class DigitstoWords
    {
        public string AmountInWords(string nAmount, string wAmount, int nSet)
        {
            decimal val;

            string tempDecValue = "";

           
            try
            {
                long intAmount = Int64.Parse(nAmount);
                if (intAmount > 0)
                {
                    if (nSet == -1)
                    {
                        nSet = ((((float)intAmount.ToString().Trim().Length / 3) > (intAmount.ToString().Trim().Length / 3))) ? (Convert.ToInt32(intAmount.ToString().Trim().Length / 3) + 1) : Convert.ToInt32(intAmount.ToString().Trim().Length / 3);
                    }
                    
                    long eAmount = Convert.ToInt64(intAmount.ToString().Trim().Substring(0, intAmount.ToString().Trim().Length - ((nSet) - 1) * 3));
                    
                    long multiplier = (long)Math.Pow(10, ((nSet - 1) * 3));
                    string[] Ones = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
                    string[] Teens = { "", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
                    string[] Tens = { "", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
                    string[] HMBT = { "", "", "Thousand", "Million", "Billion", "Trillion" };

                    intAmount = eAmount;

                    int nHundred = (int)intAmount / 100;
                    intAmount %= 100;
                    int nTen = (int)intAmount / 10;
                    intAmount %= 10;
                    int nOne = (int)intAmount;

                    //This is for hundreds
                    if (nHundred > 0)
                    {
                        wAmount = wAmount + Ones[nHundred] + " Hundred ";
                    }
                    //This is for tens and teens
                    if (nTen > 0)
                    {
                        //This is for teens
                        if (nTen == 1 && nOne > 0)
                        {
                            wAmount = wAmount + Teens[nOne] + " ";
                        }
                        //This is for tens, 10 to 90
                        else
                        {
                            wAmount = wAmount + Tens[nTen];
                            wAmount = (nOne > 0) ? (wAmount + "-" + Ones[nOne] + " ") : wAmount + " ";
                        }
                    }
                    //This is for ones, 1 to 9
                    else
                    {
                        if (nOne > 0)
                        {
                            wAmount = wAmount + Ones[nOne] + " ";
                        }
                    }
                    wAmount = wAmount + HMBT[nSet] + " ";
                    wAmount = AmountInWords(Convert.ToString(Convert.ToInt64(nAmount) - (eAmount * multiplier)).Trim() + tempDecValue, wAmount, nSet - 1);
                }
            }
            catch (Exception e)
            {

            }
            return wAmount;
        }

    }
}
