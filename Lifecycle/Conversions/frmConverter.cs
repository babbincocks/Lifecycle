using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversions
{
    public partial class frmConverter : Form
    {
        public frmConverter()
        {
            InitializeComponent();
        }



        private void btnConvert_Click(object sender, EventArgs e)
        {//This is the code for the "Convert!" button.
            try
            {
                /*
                It first checks to see if the text that has been entered into the input text
                box can be parsed into an integer. If it succeeds, it is assumed that the
                user has put in these numbers to convert them to Roman numerals, and so it
                initializes the ArabicToRoman method of the NumberConversion class with the
                number they put in. Once it finishes, it puts the output in the output text box.
                */
                if (int.TryParse(txtInput.Text, out int b))
                {
                    string a = NumberConversion.ArabicToRoman(b);
                    txtOutput.Text = a.ToString();
                }
                else
                {/*
                    If the users input doesn't properly parse into an integer, then it's assumed
                    that they are looking to convert Roman numerals to Arabic numbers, so it
                    attempts the opposite. Due to the nature of the RomanToArabic class, input
                    is protected from anything that isn't a Roman numeral.
                    */
                    int a = NumberConversion.RomanToArabic(txtInput.Text);
                    txtOutput.Text = a.ToString();
                }
                ep1.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ep1.SetError(txtInput, "The value you attempted to convert did not fit the formatting of either Arabic numbers or Roman numerals. ...well, at least those between 1 and 3999.");
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            frmList a = new frmList();
            a.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";
            txtOutput.Text = "";
            ep1.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}
