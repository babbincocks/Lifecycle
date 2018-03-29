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

        private static Dictionary<int, string> IntToRoman = new Dictionary<int, string>()
            { //This is a dictionary that will be used for Roman to Arabic. 
            //It shows each Roman numeral, and the value that they correspond to.
                {1000, "M"},
                {500, "D"},
                {100, "C"},
                {50, "L"},
                {10, "X"},
                {5, "V"},
                {1, "I"},
            };

        public static string ArabicToRoman(int Arabic)
        {

            
                string returnRoman = "";
                   
                if (Arabic < 1)
            {
                
            }

                return returnRoman;
            

        }




        public static int RomanToArabic(string roman)
        {
            try
            {
                //An initial variable for what will be returned at the end is declared.
                int returnArabic = 0;

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

                }
                //Then it finishes with returning the value that has been added into.
                return returnArabic;
            }
            catch (KeyNotFoundException ex)
            {
                ex = new KeyNotFoundException("Seems there was " +
                    "something wrong with your input. Make sure all characters you input " +
                    "are Roman Numerals, and follow the rules of Roman Numerals.");
                throw ex;
            }
        }

    }
}
