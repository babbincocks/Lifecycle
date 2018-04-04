using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversions
{
    public class NumberConversion
    {
        private static Dictionary<char, int> RomanToInt = new Dictionary<char, int>()
            { //This is a dictionary that will be used for Roman to Arabic. 
            //It shows each Roman numeral, and the value that they correspond to.
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000},
            };

        public static string ArabicToRoman(int Arabic)
        {

            
                string returnRoman = "";
            try
            {
                if (Arabic > 3999 || Arabic < 1)
                    throw new ArgumentOutOfRangeException("Your input value must be between 1 and 3999, unfortunately.", new Exception());
                while (Arabic >= 1000)
                {
                    returnRoman += "M";
                    Arabic -= 1000;
                }
                while (Arabic >= 900)
                {
                    returnRoman += "CM";
                    Arabic -= 900;
                }
                while (Arabic >= 500)
                {
                    returnRoman += "D";
                    Arabic -= 500;
                }
                while (Arabic >= 400)
                {
                    returnRoman += "CD";
                    Arabic -= 400;
                }
                while (Arabic >= 100)
                {
                    returnRoman += "C";
                    Arabic -= 100;
                }
                while (Arabic >= 90)
                {
                    returnRoman += "XC";
                    Arabic -= 90;
                }
                while (Arabic >= 50)
                {
                    returnRoman += "L";
                    Arabic -= 50;
                }
                while (Arabic >= 40)
                {
                    returnRoman += "XL";
                    Arabic -= 40;
                }
                while (Arabic >= 10)
                {
                    returnRoman += "X";
                    Arabic -= 10;
                }
                while (Arabic >= 9)
                {
                    returnRoman += "IX";
                    Arabic -= 9;
                }

                while (Arabic >= 5)
                {
                    returnRoman += "V";
                    Arabic -= 5;
                }
                while (Arabic >= 4)
                {
                    returnRoman += "IV";
                    Arabic -= 4;
                }

                while (Arabic >= 1)
                {
                    returnRoman += "I";
                    Arabic -= 1;
                }
                return returnRoman;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            

        }




        public static int RomanToArabic(string roman)
        {
            try
            {
                //An initial variable for what will be returned at the end is declared.
                
                int returnArabic = 0;
                bool let = roman.All(char.IsLetter);
                if (!let)
                {
                    throw new FormatException("Please insert only valid Roman numerals (I, V, X, L, C, D, M).");
                }
                roman = roman.ToUpper();

                if (roman.Contains("VV") || roman.Contains("LL") || roman.Contains("DD"))
                {
                    throw new FormatException("The syntax rules of Roman numerals states that you should never have two or more V's, L's, or D's together. Instead, use X to replace VV, C to replace LL, and M to replace DD.");

                }

                if (roman.Contains("IIII") || roman.Contains("XXXX") || roman.Contains("CCCC"))
                {
                    throw new FormatException("The syntax rules of Roman numerals states that you should never have any character sequentially repeated more than 3 times.");
                }

                
                /*
                 A for-loop is established that will create what will essentially function as
                 a cursor (hence the variable's name), and as long as the value (which works as
                 the position of the cursor) is less than the length of the Roman numeral being
                 tested, it will do everything in the loop, and then increment the cursor value.
                */
                for (int cursor = 0; cursor < roman.Length; cursor++)
                {
                    /*
                     This initial half to the if statement checks to see if the next cursor
                     position is less than the length of the numerals being checked (since the
                     cursor is base 0, and the actual length of the string is base 1, the only
                     time it would not fit this criteria is when it's on the last numeral), and
                     that the value the cursor is currently on is less than the value of the
                     roman numeral that will come next. If both of these conditions are true,
                     then the value that the cursor is currently on is subtracted from the
                     current value of the return value.
                     */
                    if (cursor + 1 < roman.Length && RomanToInt[roman[cursor]] <
                        RomanToInt[roman[cursor + 1]])
                    {
                        returnArabic -= RomanToInt[roman[cursor]];
                    }
                    /*
                     If the numeral the cursor is currently on does NOT fit either of those
                     criteria, the respective value of the numeral is added on to the return
                     value instead. 
                     */
                    else
                    {
                        returnArabic += RomanToInt[roman[cursor]];
                    }

                    if ()
                    /*
                    The reason for the subtraction part of this is so when you get numerals
                    like, say, MDLIV, and the cursor has scanned the first three numerals 
                    (giving the return value a value of 1550), it will check if the I is not
                    the last number (fits that criteria), and that the next numeral is greater
                    than itself (which V is, so it fits that criteria as well), so it subtracts
                    I (1), and then it'll add V(5), so it works out.
                     */

                    

                     if (returnArabic > 3999)
                    {
                        throw new ArgumentOutOfRangeException("Any value you input that is larger than 3999 will be inaccurate, unfortunately.", new Exception());
                    }
                }
                //Then it finishes with returning the value that has been added into.
                return returnArabic;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
