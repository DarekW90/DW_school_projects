using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main_app
{
    public partial class calculator1 : Form
    {
        public calculator1()
        {
            InitializeComponent();
        }

        string CalTotal;
        long num1;
        long num2;
        string option;
        long result;

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTotal.Text))
            {
                // uniknięcie crasha porgramu w przypadku niepodania żadnej wartości przed kliknięciem znaku równości.
                return;
            }

            num2 = long.Parse(txtTotal.Text);

            if (option == ("+"))
                result = num1 + num2;

            if (option == ("-"))
                result = num1 - num2;

            if (option == ("*"))
                result = num1 * num2;

            if (option == ("/"))
                result = num1 / num2;

            if (result > 999999999)
            {
                txtTotal.Text = "error";
            }
            else 
            { 
                txtTotal.Text = result + "";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn9.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn0.Text;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = long.Parse(txtTotal.Text);
            txtTotal.Clear();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = long.Parse(txtTotal.Text);
            txtTotal.Clear();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = long.Parse(txtTotal.Text);
            txtTotal.Clear();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = long.Parse(txtTotal.Text);
            txtTotal.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTotal.Clear();
            result = (0);
            num1 = (0);
            num2 = (0);
        }

        private void calculator1_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainApp appMain = new mainApp();
            appMain.Show();
        }
    }
}
