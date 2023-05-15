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
    public partial class photoGalery : Form
    {
        List<string> image_location = new List<string>();
        List<Firework> fireworks_list = new List<Firework>();
        int backgroundNumber;


        public photoGalery()
        {
            InitializeComponent();
            SetUp();
        }

        private void SetUp()
        {
            image_location = Directory.GetFiles("background", "*.jpg").ToList();
            this.BackgroundImage = Image.FromFile(image_location[0]);
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (backgroundNumber < image_location.Count - 1)
            {
                backgroundNumber++;
            }
            else
            {
                backgroundNumber = 0;
            }
            this.BackgroundImage = Image.FromFile(image_location[backgroundNumber]);

        }

        private void FormMouseDown(object sender, MouseEventArgs e)
        {
            Point mousePosition = new Point();
            mousePosition.X = e.X;
            mousePosition.Y = e.Y;

            Firework newFirework = new Firework();
            newFirework.postion.X = mousePosition.X - (newFirework.width / 2);
            newFirework.postion.Y = mousePosition.Y - (newFirework.height / 2);
            fireworks_list.Add(newFirework);
        }

        private void FormPaintEvent(object sender, PaintEventArgs e)
        {
            foreach (Firework newFirework in fireworks_list.ToList())
            {
                if (newFirework.animationComplite == false)
                {
                    e.Graphics.DrawImage(newFirework.firework, newFirework.postion.X,
                        newFirework.postion.Y, newFirework.width, newFirework.height);
                }
            }
        }

        private void AnimationTimeEvent(object sender, EventArgs e)
        {
            if (fireworks_list != null)
            {
                foreach (Firework firework in fireworks_list.ToList())
                {
                    if (firework.animationComplite == false)
                    {
                        firework.AnimateFirework();
                    }
                    else
                    {
                        fireworks_list.Remove(firework);
                    }
                }
            }

            this.Invalidate();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            photoStart.Visible = false;
            this.Focus();
        }
    }
}
