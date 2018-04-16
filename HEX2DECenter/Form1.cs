using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HEX2DEC_enter_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                string HEX, H;
                int DEC = 0, L, X = 0, A;
                HEX = textBox1.Text;
                L = HEX.Length;
                while (L > X)
                {
                    H = HEX.Substring(X, 1);
                    A = Convert.ToChar(H);
                    if (A >= 48 && A <= 57) A -= 48;
                    if (A >= 65 && A <= 70) A -= 55;
                    if (A >= 97 && A <= 102) A -= 87;
                    DEC += (int)(A * Math.Pow(16, L - (X++ + 1)));
                }
                textBox2.Text = DEC.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
