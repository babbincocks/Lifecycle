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
    public partial class ListTest : Form
    {
        public ListTest()
        {
            InitializeComponent();
        }

        private void btnRToA_Click(object sender, EventArgs e)
        {

        }

        private void btnAToR_Click(object sender, EventArgs e)
        {
            try
            {
                int count = 1;
                while (count <= 3999)
                {
                    string a = NumberConversion.ArabicToRoman(int.Parse(lbOutput.Text));
                    lbOutput.Text = a;
                    count++;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
