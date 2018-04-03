﻿using System;
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
                bool hasInt = roman.All(char.IsDigit);
                if (hasInt)
                {
                    throw new FormatException("Please insert only valid Roman numerals (I, V, X, L, C, D, M).");

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

    ////This block of variables retrieve a count of how many times each character
    ////shows up in what the user put in, so the user can't just put in 20 I's,
    ////for example; they would have to put in "XX".
    //int mCo = roman.Split('M').Length - 1;
    //int dCo = roman.Split('D').Length - 1;
    //int cCo = roman.Split('C').Length - 1;
    //int lCo = roman.Split('L').Length - 1;
    //int xCo = roman.Split('X').Length - 1;
    //int vCo = roman.Split('V').Length - 1;
    //int iCo = roman.Split('I').Length - 1;

    //if (mCo > 3 || dCo > 1 || cCo > 3 || lCo > 1 || xCo > 3 || vCo > 1 || iCo > 3)
    //    throw new AggregateException("You have too many of one of your numerals: there can't be more than one D, L, or V, and no more than 3 of any other numeral.", new Exception[mCo, dCo, cCo, lCo, xCo, vCo, iCo]);

}
