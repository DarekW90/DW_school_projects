using System.Drawing.Drawing2D;

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

        private void btnBreakOut_Click(object sender, EventArgs e)
        {
            BreakOut breakOutGame = new BreakOut();
            breakOutGame.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void mainApp_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void mainApp_paint(object sender, PaintEventArgs e)
        {
            Graphics mgraphics = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(96, 155, 173), 1);

            Rectangle area = new Rectangle(0, 0, this.Width, this.Height - 1);
            LinearGradientBrush lgb = new LinearGradientBrush(area, Color.FromArgb(96, 155, 233), Color.FromArgb(245, 251, 251), LinearGradientMode.Vertical);
            mgraphics.FillRectangle(lgb, area);
            mgraphics.DrawRectangle(pen, area);
        }
    }
}