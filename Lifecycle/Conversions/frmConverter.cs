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
        {
            try
            {

                if (int.TryParse(txtInput.Text, out int b))
                {
                    string a = NumberConversion.ArabicToRoman(b);
                    txtOutput.Text = a.ToString();
                }
                else
                {
                    int a = NumberConversion.RomanToArabic(txtInput.Text);
                    txtOutput.Text = a.ToString();
                }
                ep1.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ep1.SetError(txtInput, "The value you attempted to convert did not fit the formatting of either Arabic numbers or Roman numerals.");
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
