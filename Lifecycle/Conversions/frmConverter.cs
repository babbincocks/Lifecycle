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

        private void btnRToA_Click(object sender, EventArgs e)
        {
            try
            {
                int a = NumberConversion.RomanToArabic(txtInput.Text);
                txtOutput.Text = a.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAToR_Click(object sender, EventArgs e)
        {
            try
            {
                string a = NumberConversion.ArabicToRoman(int.Parse(txtInput.Text));
                txtOutput.Text = a;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}
