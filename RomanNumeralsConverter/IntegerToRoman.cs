using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RomanNumeralsConverter
{
    public partial class IntegerToRoman : Form
    {
        ConvertFunctions converter = new ConvertFunctions();
        string kontrolRoman = null;
        int ikiliSayi = 0;
       
        public IntegerToRoman()
        {
            InitializeComponent();
            buttonIntegerToRoman.Enabled = false;
        }

        private void buttonIntegerToRoman_Click(object sender, EventArgs e)
        {
            try
            {
                ikiliSayi = Convert.ToInt32(textBoxInteger.Text);
                if (0 < ikiliSayi && ikiliSayi < 4000)
                {
                    kontrolRoman = converter.romayaCevir(ikiliSayi);
                    textBoxRoman.Text = kontrolRoman;
                }
                else
                {
                    MessageBox.Show("0-4000 ARALIĞINDA BİR TAMSAYI GİRİNİZ.");
                }
            }
            
            catch 
            {
                MessageBox.Show("0-4000 ARALIĞINDA BİR TAMSAYI GİRİNİZ.");
            }
                                    
        }

        private void textBoxInteger_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }              
        }

        private void textBoxInteger_TextChanged(object sender, EventArgs e)
        {
            if (textBoxInteger.Text.ToString() != "")
            {
                buttonIntegerToRoman.Enabled = true;
            }

            else 
            {
                buttonIntegerToRoman.Enabled = false;
            }
        }
    }
}
