using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LengthCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string input;
        double output;

        private void lengthconvert(int kind, double len)
        {
            if (kind != 0) txtCM.Text = string.Format("{0:0.##########}", len);
            if (kind != 1) txtM.Text = string.Format("{0:0.##########}", len / 100);
            if (kind != 2) txtKM.Text = string.Format("{0:0.##########}", len / 100000);
            if (kind != 3) txtIn.Text = string.Format("{0:0.##########}", len / 2.54);
            if (kind != 4) txtFt.Text = string.Format("{0:0.##########}", len / 30.48);
            if (kind != 5) txtYard.Text = string.Format("{0:0.##########}", len / 91.44);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnAllClear_Click(object sender, EventArgs e)
        {
            txtCM.Text = "";
            txtM.Text = "";
            txtKM.Text = "";
            txtIn.Text = "";
            txtFt.Text = "";
            txtYard.Text = "";
            txtInfo.Text = "";
        }

        private void txtCM_KeyUp(object sender, KeyEventArgs e)
        {
            input = txtCM.Text;

            if (double.TryParse(input, out output) == true)
            {
                lengthconvert(0, output);
            }
            else
            {
                txtInfo.Text = "Please input a number";
                txtCM.Text = "";
            }
        }

        private void txtM_KeyUp(object sender, KeyEventArgs e)
        {
            input = txtM.Text;

            if (double.TryParse(input, out output) == true)
            {
                lengthconvert(1, output * 100);
            }
            else
            {
                txtInfo.Text = "Please input a number";
                txtM.Text = "";
            }
        }

        private void txtKM_KeyUp(object sender, KeyEventArgs e)
        {
            input = txtKM.Text;

            if (double.TryParse(input, out output) == true)
            {
                lengthconvert(2, output * 100000);
            }
            else
            {
                txtInfo.Text = "Please input a number";
                txtKM.Text = "";
            }
        }

        private void txtIn_KeyUp(object sender, KeyEventArgs e)
        {
            input = txtIn.Text;

            if (double.TryParse(input, out output) == true)
            {
                lengthconvert(3, output * 2.54);
            }
            else
            {
                txtInfo.Text = "Please input a number";
                txtIn.Text = "";
            }
        }

        private void txtFt_KeyUp(object sender, KeyEventArgs e)
        {
            input = txtFt.Text;

            if (double.TryParse(input, out output) == true)
            {
                lengthconvert(4, output * 30.48);
            }
            else
            {
                txtInfo.Text = "Please input a number";
                txtFt.Text = "";
            }
        }

        private void txtYard_KeyUp(object sender, KeyEventArgs e)
        {
            input = txtYard.Text;

            if (double.TryParse(input, out output) == true)
            {
                lengthconvert(5, output * 91.44);
            }
            else
            {
                txtInfo.Text = "Please input a number";
                txtYard.Text = "";
            }
        }
    }
}
