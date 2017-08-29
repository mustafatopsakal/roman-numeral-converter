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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonIntegerToRoman_Click(object sender, EventArgs e)
        {
            IntegerToRoman formIntegerToRoman = new IntegerToRoman();
            formIntegerToRoman.Enabled = true;
            formIntegerToRoman.Show();
        }

        private void buttonRomanToInteger_Click(object sender, EventArgs e)
        {
            RomanToInteger formRomanToInteger = new RomanToInteger();
            formRomanToInteger.Enabled = true;
            formRomanToInteger.Show();
        }
    }
}
