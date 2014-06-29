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

            //Checking of the input value is a number
            //if (!Decimal.TryParse(nAmount, out val))
            //{
            //    return null;
            //}
            string tempDecValue = "";

            //Checking if the input value contains a decimal point
            //if (nAmount.Contains("."))
            //{
            //    tempDecValue = nAmount.Substring(nAmount.IndexOf("."));

            //    //Using only the part before the decimal point 
            //    nAmount = nAmount.Remove(nAmount.IndexOf(tempDecValue));
            //}

            try
            {
                long intAmount = Int64.Parse(nAmount);
                if (intAmount > 0)
                {
                    //if ((intAmount.ToString().Trim().Length / 3) > (Convert.ToInt64(intAmount.ToString().Trim().Length / 3)))
                    //{
                    //    nSet = Convert.ToInt32(intAmount.ToString().Trim().Length / 3) + 1;
                    //}
                    //else
                    //{
                    //    nSet = Convert.ToInt32(intAmount.ToString().Trim().Length / 3);
                    //}
                    if (nSet == -1)
                    {
                        nSet = ((((float)intAmount.ToString().Trim().Length / 3) > (intAmount.ToString().Trim().Length / 3))) ? (Convert.ToInt32(intAmount.ToString().Trim().Length / 3) + 1) : Convert.ToInt32(intAmount.ToString().Trim().Length / 3);
                    }
                    //nSet = Convert.ToInt32(intAmount.ToString().Trim().Length / 3);
                    long eAmount = Convert.ToInt64(intAmount.ToString().Trim().Substring(0, intAmount.ToString().Trim().Length - ((nSet) - 1) * 3));
                    //long multiplier = 10 ^ ((nSet - 1) * 3);
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
                            //if (nOne > 0)
                            //{
                            //    wAmount = wAmount + "-" + Ones[nOne] + " ";
                            //}
                            //else
                            //{
                            //    wAmount = wAmount + " ";
                            //}
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
                else
                {
                    //if (Int64.Parse(nAmount) == 0)
                    //{
                    //    nAmount=nAmount
                    //}

                }
            }
            catch (Exception e)
            {

            }
            return wAmount;
        }




        //            Public Function AmountInWords(ByVal nAmount As String, Optional ByVal wAmount _
        //                 As String = vbNullString, Optional ByVal nSet As Object = Nothing) As String
        //    'Let's make sure entered value is numeric
        //    If Not IsNumeric(nAmount) Then Return "Please enter numeric values only."

        //    Dim tempDecValue As String = String.Empty : If InStr(nAmount, ".") Then _
        //        tempDecValue = nAmount.Substring(nAmount.IndexOf("."))
        //    nAmount = Replace(nAmount, tempDecValue, String.Empty)

        //    Try
        //        Dim intAmount As Long = nAmount
        //        If intAmount > 0 Then
        //            nSet = IIf((intAmount.ToString.Trim.Length / 3) _
        //                > (CLng(intAmount.ToString.Trim.Length / 3)), _
        //              CLng(intAmount.ToString.Trim.Length / 3) + 1, _
        //                CLng(intAmount.ToString.Trim.Length / 3))
        //            Dim eAmount As Long = Microsoft.VisualBasic.Left(intAmount.ToString.Trim, _
        //              (intAmount.ToString.Trim.Length - ((nSet - 1) * 3)))
        //            Dim multiplier As Long = 10 ^ (((nSet - 1) * 3))

        //            Dim Ones() As String = _
        //            {"", "One", "Two", "Three", _
        //              "Four", "Five", _
        //              "Six", "Seven", "Eight", "Nine"}
        //            Dim Teens() As String = {"", _
        //            "Eleven", "Twelve", "Thirteen", _
        //              "Fourteen", "Fifteen", _
        //              "Sixteen", "Seventeen", "Eighteen", "Nineteen"}
        //            Dim Tens() As String = {"", "Ten", _
        //            "Twenty", "Thirty", _
        //              "Forty", "Fifty", "Sixty", _
        //              "Seventy", "Eighty", "Ninety"}
        //            Dim HMBT() As String = {"", "", _
        //            "Thousand", "Million", _
        //              "Billion", "Trillion", _
        //              "Quadrillion", "Quintillion"}

        //            intAmount = eAmount

        //            Dim nHundred As Integer = intAmount \ 100 : intAmount = intAmount Mod 100
        //            Dim nTen As Integer = intAmount \ 10 : intAmount = intAmount Mod 10
        //            Dim nOne As Integer = intAmount \ 1

        //            If nHundred > 0 Then wAmount = wAmount & _
        //            Ones(nHundred) & " Hundred " 'This is for hundreds                
        //            If nTen > 0 Then 'This is for tens and teens
        //                If nTen = 1 And nOne > 0 Then 'This is for teens 
        //                    wAmount = wAmount & Teens(nOne) & " "
        //                Else 'This is for tens, 10 to 90
        //                    wAmount = wAmount & Tens(nTen) & IIf(nOne > 0, "-", " ")
        //                    If nOne > 0 Then wAmount = wAmount & Ones(nOne) & " "
        //                End If
        //            Else 'This is for ones, 1 to 9
        //                If nOne > 0 Then wAmount = wAmount & Ones(nOne) & " "
        //            End If
        //            wAmount = wAmount & HMBT(nSet) & " "
        //            wAmount = AmountInWords(CStr(CLng(nAmount) - _
        //              (eAmount * multiplier)).Trim & tempDecValue, wAmount, nSet - 1)
        //        Else
        //            If Val(nAmount) = 0 Then nAmount = nAmount & _
        //            tempDecValue : tempDecValue = String.Empty
        //            If (Math.Round(Val(nAmount), 2) * 100) > 0 Then wAmount = _
        //              Trim(AmountInWords(CStr(Math.Round(Val(nAmount), 2) * 100), _
        //              wAmount.Trim & " Pesos And ", 1)) & " Cents"
        //        End If
        //    Catch ex As Exception
        //        MessageBox.Show("Error Encountered: " & ex.Message, _
        //          "Convert Numbers To Words", _
        //          MessageBoxButtons.OK, MessageBoxIcon.Error)
        //        Return "!#ERROR_ENCOUNTERED"
        //    End Try

        //    'Trap null values
        //    If IsNothing(wAmount) = True Then wAmount = String.Empty Else wAmount = _
        //      IIf(InStr(wAmount.Trim.ToLower, "pesos"), _
        //      wAmount.Trim, wAmount.Trim & " Pesos")

        //    'Display the result
        //    Return wAmount
        //End Function


    }
}
