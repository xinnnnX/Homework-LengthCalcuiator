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
                txtM.Text = string.Format("{0:0.##########}", output / 100);
                txtKM.Text = string.Format("{0:0.##########}", output / 100000);
                txtIn.Text = string.Format("{0:0.##########}", output / 2.54);
                txtFt.Text = string.Format("{0:0.##########}", output / 30.48);
                txtYard.Text = string.Format("{0:0.##########}", output / 91.44);
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
                output = output * 100;
                txtCM.Text = string.Format("{0:0.##########}", output);
                txtKM.Text = string.Format("{0:0.##########}", output / 100000);
                txtIn.Text = string.Format("{0:0.##########}", output / 2.54);
                txtFt.Text = string.Format("{0:0.##########}", output / 30.48);
                txtYard.Text = string.Format("{0:0.##########}", output / 91.44);
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
                output = output * 100000;
                txtCM.Text = string.Format("{0:0.##########}", output);
                txtM.Text = string.Format("{0:0.##########}", output / 100);
                txtIn.Text = string.Format("{0:0.##########}", output / 2.54);
                txtFt.Text = string.Format("{0:0.##########}", output / 30.48);
                txtYard.Text = string.Format("{0:0.##########}", output / 91.44);
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
                output = output * 2.54;
                txtCM.Text = string.Format("{0:0.##########}", output);
                txtM.Text = string.Format("{0:0.##########}", output / 100);
                txtKM.Text = string.Format("{0:0.##########}", output / 100000);
                txtFt.Text = string.Format("{0:0.##########}", output / 30.48);
                txtYard.Text = string.Format("{0:0.##########}", output / 91.44);
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
                output = output * 30.48;
                txtCM.Text = string.Format("{0:0.##########}", output);
                txtM.Text = string.Format("{0:0.##########}", output / 100);
                txtKM.Text = string.Format("{0:0.##########}", output / 100000);
                txtIn.Text = string.Format("{0:0.##########}", output / 2.54);
                txtYard.Text = string.Format("{0:0.##########}", output / 91.44);
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
                output = output * 91.44;
                txtCM.Text = string.Format("{0:0.##########}", output);
                txtM.Text = string.Format("{0:0.##########}", output / 100);
                txtKM.Text = string.Format("{0:0.##########}", output / 100000);
                txtIn.Text = string.Format("{0:0.##########}", output / 2.54);
                txtFt.Text = string.Format("{0:0.##########}", output / 30.48);
            }
            else
            {
                txtInfo.Text = "Please input a number";
                txtYard.Text = "";
            }
        }
    }
}
