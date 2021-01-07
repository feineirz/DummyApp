using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DummyApp
{
    public partial class frmMain : Form
    {
        public void calculate()
        {
            decimal sum = 0;
            sum += num1000d.Value * 1000;
            sum += num500d.Value * 500;
            sum += num100d.Value * 100;
            sum += num50d.Value * 50;
            sum += num20d.Value * 20;
            sum += num10d.Value * 10;
            sum += num5d.Value * 5;
            sum += num1d.Value;

            lblDisplay.Text = Convert.ToInt32(sum).ToString();
        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in pnlInput.Controls)
            {
                if(typeof(NumericUpDown) == ctrl.GetType())
                {
                    NumericUpDown num = (NumericUpDown)ctrl;
                    num.Value = 0;
                }
            }
            num1000d.Focus();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            calculate();
        }

        private void num_ValueChanged(object sender, EventArgs e)
        {
            calculate();
        }

        private void num_GotFocus(object sender, EventArgs e)
        {
            NumericUpDown num = (NumericUpDown)sender;
            num.Select(0, 10);
        }
    }
}
