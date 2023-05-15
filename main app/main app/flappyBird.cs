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
    public partial class flappyBird : Form
    {

        int pipeSpeed = 8;
        int gravity = 15;
        int score = 0;

        bool gameOver = false;

        public flappyBird()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pipeTop_Click(object sender, EventArgs e)
        {

        }

        private void ground_Click(object sender, EventArgs e)
        {

        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            fBird.Top += gravity;
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            scoreText.Text = "Punkty: " + score;
            pipeSpeedtxt.Text = "Speed: " + (pipeSpeed - 8);


            if (pipeBottom.Left < -80)
            {
                pipeBottom.Left = 900;
                score++;
                pipeSpeed++;
            }
            if (pipeTop.Left < -130)
            {
                pipeTop.Left = 700;
                score++;
            }
            if (fBird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                fBird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                fBird.Bounds.IntersectsWith(ground.Bounds) ||
                fBird.Top < -25
                )
            {
                endGame();
            }
        }

        private void gameKeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }
        }

        private void gameKeyIsUp(object sender, KeyPressEventArgs e)
        {

        }

        private void gameKeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }
            if (e.KeyCode == Keys.R && gameOver)
            {
                restartGame();
            }
        }

        private void endGame()
        {
            gameTimer.Stop();
            scoreText.Text += " Koniec Gry!";
            gameOverInfo.Text += " Nacisnij R by powtórzyć";
            sumMsg.Text += "Twoj wynik to: " + score + " Osiągnięto prędkość: " + (pipeSpeed - 8);



            gameOver = true;
        }

        private void pipeSpeedtxt_Click(object sender, EventArgs e)
        {

        }
        private void restartGame()
        {
            gameOver = false;
            fBird.Location = new Point(76, 265);
            pipeTop.Left = 800;
            pipeBottom.Left = 1200;

            score = 0;
            pipeSpeed = 8;
            scoreText.Text = " ";
            gameTimer.Start();
            gameOverInfo.Text = " ";
            sumMsg.Text = " ";


        }

        private void flappyBird_Load(object sender, EventArgs e)
        {

        }
    }
}
