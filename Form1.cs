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

        }

        private void txtCM_KeyUp(object sender, KeyEventArgs e)
        {
            double input;
            input = Convert.ToDouble(txtCM.Text);

            txtM.Text = string.Format("{0:0.##########}", input / 100);
            txtKM.Text = string.Format("{0:0.##########}", input / 100000);
            txtIn.Text = string.Format("{0:0.##########}", input / 2.54);
            txtFt.Text = string.Format("{0:0.##########}", input / 30.48);
            txtYard.Text = string.Format("{0:0.##########}", input / 91.44);
        }

        private void txtM_KeyUp(object sender, KeyEventArgs e)
        {
            double input;
            input = Convert.ToDouble(txtM.Text);
            input = input * 100;

            txtCM.Text = string.Format("{0:0.##########}", input);
            txtKM.Text = string.Format("{0:0.##########}", input / 100000);
            txtIn.Text = string.Format("{0:0.##########}", input / 2.54);
            txtFt.Text = string.Format("{0:0.##########}", input / 30.48);
            txtYard.Text = string.Format("{0:0.##########}", input / 91.44);
        }

        private void txtKM_KeyUp(object sender, KeyEventArgs e)
        {
            double input;
            input = Convert.ToDouble(txtKM.Text);
            input = input * 100000;

            txtCM.Text = string.Format("{0:0.##########}", input);
            txtM.Text = string.Format("{0:0.##########}", input / 100);
            txtIn.Text = string.Format("{0:0.##########}", input / 2.54);
            txtFt.Text = string.Format("{0:0.##########}", input / 30.48);
            txtYard.Text = string.Format("{0:0.##########}", input / 91.44);
        }

        private void txtIn_KeyUp(object sender, KeyEventArgs e)
        {
            double input;
            input = Convert.ToDouble(txtIn.Text);
            input = input * 2.54;

            txtCM.Text = string.Format("{0:0.##########}", input);
            txtM.Text = string.Format("{0:0.##########}", input / 100);
            txtKM.Text = string.Format("{0:0.##########}", input / 100000);
            txtFt.Text = string.Format("{0:0.##########}", input / 30.48);
            txtYard.Text = string.Format("{0:0.##########}", input / 91.44);
        }

        private void txtFt_KeyUp(object sender, KeyEventArgs e)
        {
            double input;
            input = Convert.ToDouble(txtFt.Text);
            input = input * 30.48;

            txtCM.Text = string.Format("{0:0.##########}", input);
            txtM.Text = string.Format("{0:0.##########}", input / 100);
            txtKM.Text = string.Format("{0:0.##########}", input / 100000);
            txtIn.Text = string.Format("{0:0.##########}", input / 2.54);
            txtYard.Text = string.Format("{0:0.##########}", input / 91.44);
        }

        private void txtYard_KeyUp(object sender, KeyEventArgs e)
        {
            double input;
            input = Convert.ToDouble(txtYard.Text);
            input = input * 91.44;

            txtCM.Text = string.Format("{0:0.##########}", input);
            txtM.Text = string.Format("{0:0.##########}", input / 100);
            txtKM.Text = string.Format("{0:0.##########}", input / 100000);
            txtIn.Text = string.Format("{0:0.##########}", input / 2.54);
            txtFt.Text = string.Format("{0:0.##########}", input / 30.48);
        }
    }
}
