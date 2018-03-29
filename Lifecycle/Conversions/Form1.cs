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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRToA_Click(object sender, EventArgs e)
        {

                int a = NumberConversion.RomanToArabic(inputText.Text);
                outputText.Text = a.ToString();


        }

        private void btnAToR_Click(object sender, EventArgs e)
        {
            string a = NumberConversion.ArabicToRoman(int.Parse(inputText.Text));
            outputText.Text = a;
            
        }
    }

}
