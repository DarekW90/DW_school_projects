namespace kalkulator
{
    public partial class calculator : Form
    {
        public calculator()
        {
            InitializeComponent();
            this.Text = "Kalkulator";
        }


        string CalTotal;
        int num1;
        int num2;
        string option;
        int result;


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
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

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = int.Parse(txtTotal.Text);
            txtTotal.Clear();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = int.Parse(txtTotal.Text);
            txtTotal.Clear();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = int.Parse(txtTotal.Text);
            txtTotal.Clear();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = int.Parse(txtTotal.Text);
            txtTotal.Clear();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTotal.Text))
            {
                // unikniêcie crasha porgramu w przypadku niepodania ¿adnej wartoœci przed klikniêciem znaku równoœci.
                return;
            }

            num2 = int.Parse(txtTotal.Text);

            if (option == ("+"))
                result = num1 + num2;

            if (option == ("-"))
                result = num1 - num2;

            if (option == ("*"))
                result = num1 * num2;

            if (option == ("/"))
                result = num1 / num2;

            txtTotal.Text = result + "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTotal.Clear();
            result = (0);
            num1 = (0);
            num2 = (0);
        }
    }
}