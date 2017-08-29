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
    public partial class RomanToInteger : Form
    {
        ConvertFunctions converter = new ConvertFunctions();

        public RomanToInteger()
        {
            InitializeComponent();
            buttonRomanToInteger.Enabled = false;
        }

        private void buttonRomanToInteger_Click(object sender, EventArgs e)
        {
                int sonuc = converter.ikiliyeCevir(textBoxRoman.Text.ToString());

                if (sonuc == -1)
                {
                    MessageBox.Show("HATALI BİR ROMA RAKAMI GİRİLDİ");
                }
                else
                {
                    textBoxInteger.Text = Convert.ToString(sonuc);
                }     
        }

        private void textBoxRoman_TextChanged(object sender, EventArgs e)
        {
            if (textBoxRoman.Text.ToString() != "")
            {
                buttonRomanToInteger.Enabled = true;
            }
            else
            {
                buttonRomanToInteger.Enabled = false;
            }
        }
    }
}
