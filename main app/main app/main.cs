namespace main_app
{
    public partial class mainApp : Form
    {
        public mainApp()
        {
            InitializeComponent();
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            calculator1 calculator = new calculator1();
            calculator.ShowDialog();
        }
    }
}