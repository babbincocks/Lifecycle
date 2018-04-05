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
            { //This is a dictionary that will be used for Roman to Arabic conversions. 
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

            //This announces an initial variable that will be the Roman numeral that is returned at the end.
            string returnRoman = "";
            try
            {
                //First we check to see if the user input is out of range of what we want to allow with an if statement.
                if (Arabic > 3999 || Arabic < 1)
                    throw new ArgumentOutOfRangeException("Your input value must be between 1 and 3999, unfortunately.", new Exception());
                //Then we check to see if the user put any decimals in their statement (handles both forms of decimals used).
                //Since we can't really handle decimals either, those can't be allowed.
                if (Arabic.ToString().Contains(".") || Arabic.ToString().Contains(","))
                {
                    throw new FormatException("Decimals aren't allowed.");
                }
                //Then it checks to see if thethe number is greater than 1000, and if so, it will add an M to the roman numeral,
                //and subtract 1000 from the value of the user input. It will keep doing this until the while loop is no longer true,
                //up to a maximum of 3 times (as we made sure the value can't be 4000 or more). 
                while (Arabic >= 1000)
                {
                    returnRoman += "M";
                    Arabic -= 1000;
                }
                //Then the same process repeats for 900, and adds the special ordering of CM, until it can't anymore.
                //This repeats for every number, going down in value to the next that requires either a special ordering
                //of characters, or a new character altogether.
                while (Arabic >= 900)
                {
                    returnRoman += "CM";
                    Arabic -= 900;
                }
                //Here's 500's (D's)
                while (Arabic >= 500)
                {
                    returnRoman += "D";
                    Arabic -= 500;
                }
                //400's (CD's)
                while (Arabic >= 400)
                {
                    returnRoman += "CD";
                    Arabic -= 400;
                }
                //100's (C's)
                while (Arabic >= 100)
                {
                    returnRoman += "C";
                    Arabic -= 100;
                }
                //And so on and so forth
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
                //Until we get down to 1 (I), and due to the amounts of each value that was covered, it should follow the rules of
                //Roman numerals, without too many repeats at any point.
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
        {//I wanted inputs from the user to have to follow the grammatical rules of Roman numerals
            //so there will be checks in this method to ensure that the user's input follows these rules.
            try
            {
                //An initial variable for what will be returned at the end is declared.
                int returnArabic = 0;



                /*This checks for a decimal point, and brings up the proper error message.
                The reason why it's down here is because of how the code for the convert
                button works, in that it checks to see if all characters used are numbers.
                If they are, it goes for ArabicToRoman, but if it isn't, it goes to
                RomanToArabic. As "." is not a number, and would be used if someone tried
                a decimal, it goes here in the RomanToArabic method.
                */
                if (roman.Contains("."))
                {
                    throw new FormatException("Decimals aren't allowed.");
                }

                /*
                 This is another check, to make sure that there aren't any values that aren't 
                 letters. If they input a letter that isn't a Roman numeral, it will still be 
                 covered, as it won't be in the dictionary that was created earlier.
                 */
                bool let = roman.All(char.IsLetter);
                if (!let)
                {
                    throw new FormatException("Please insert only valid Roman numerals (I, V, X, L, C, D, M).");
                }
                roman = roman.ToUpper();

                //This bit ensures there aren't any sequentially repeating V's, L's, or D's.
                if (roman.Contains("VV") || roman.Contains("LL") || roman.Contains("DD"))
                {
                    throw new FormatException("The syntax rules of Roman numerals states that you should never have two or more V's, L's, or D's together. Instead, use X to replace VV, C to replace LL, and M to replace DD.");

                }

                //That there aren't too many sequential X's or C's.
                if (roman.Contains("XXXX") || roman.Contains("CCCC"))
                {
                    throw new FormatException("The syntax rules of Roman numerals states that you should never have any character sequentially repeated more than 3 times.");
                }

                /*
                There technically aren't supposed to be four I's in a row either, but I
                set up a special way to allow users to input just "IIII" and have it work,
                but something like "VIIII" will not be allowed. It begins with a Boolean
                variable that starts out false. If the user's input contains "IIII", this
                variable is set to true. After the end of the for loop coming up, there will 
                be the other half to this.
                */
                bool c = false;
                if (roman.Contains("IIII"))
                {
                    c = true;
                }

                //I's can't be directly subtracted from such large values.
                if (roman.Contains("IM") || roman.Contains("ID") || roman.Contains("IC"))
                {
                    throw new FormatException("The syntax rules of Roman numerals states that you can't put I's next to M's, D's, or C's in a subtractive sense.");
                }

                //X can't be directly subtracted from such large values.
                if (roman.Contains("XD") || roman.Contains("XM"))
                {
                    throw new FormatException("The syntax rules of Roman numerals states that you can't put X's next to M's or D's in a subtractive sense.");
                }
                //V can't be directly subtracted from such large values.
                if (roman.Contains("VM") || roman.Contains("VD") || roman.Contains("VC"))
                {
                    throw new FormatException("The syntax rules of Roman numerals states that you can't put V's next to M's, D's, or C's in a subtractive sense.");
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

                    //if ()
                    /*
                    The reason for the subtraction part of this is so when you get numerals
                    like, say, MDLIV, and the cursor has scanned the first three numerals 
                    (giving the return value a value of 1550), it will check if the I is not
                    the last number (fits that criteria), and that the next numeral is greater
                    than itself (which V is, so it fits that criteria as well), so it subtracts
                    I (1), and then it'll add V(5), so it works out.
                     */


                    //This is one last check to see if the number, after all that has happened,
                    //is over 3999. If it is, it returns an error, telling the user to stick
                    //with values 3999 and under.
                    if (returnArabic > 3999)
                    {
                        throw new ArgumentOutOfRangeException("Any value you input that is larger than 3999 will be inaccurate, unfortunately.", new Exception());
                    }

                    
                }
                /*
                 Here is the other half to the Boolean expression from above the for loop.
                 This activates if the input string contained "IIII". It checks if the string
                 was just "IIII". If it was, it sets the return value to 4. Otherwise, it
                 returns an error.
                 */
                if (c)
                {
                    if (roman == "IIII")
                    {
                        returnArabic = 4;
                    }
                    else
                    {
                        throw new FormatException("The syntax rules of Roman numerals technically don't allow for there to be 4 I's in a row, but it's commonly done to represent just the number 4. This will allow 4 I's by themselves, but in no other context.");
                    }
                }
                //Finally, it returns the value that has been added into.
                return returnArabic;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //The rest of the code here is just a Hex to Integer converter, not necessarily part of the assignment. Haven't even really
        //tested it either.
        public static int ArabicToHex(string Arabic)
        {
           
            try
            {
                int returnHex = Convert.ToInt32(Arabic, 16);

                return returnHex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static int HexToArabic(string Hex)
        {
            try
            {
                int returnArabic = Convert.ToInt32(Hex, 10);

                return returnArabic;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}
