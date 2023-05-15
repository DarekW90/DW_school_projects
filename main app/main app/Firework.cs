using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main_app
{
    internal class Firework
    {
        public int height;
        public int width;
        public int frames;
        public int current_frame = 0;
        public Point postion = new Point();
        public List<string> image_location = new List<string>();
        public bool animationComplite = false;
        public Image firework;

        public Firework()
        {
            image_location = Directory.GetFiles("images", "*.png").ToList();
            height = 200;
            width = 200;
            firework = Image.FromFile(image_location[0]);
            frames = image_location.Count;
        }


        public void AnimateFirework()
        {
            if (current_frame < frames -1 )
            {
                current_frame++;
                firework = Image.FromFile(image_location[current_frame]);
            }
            else
            {
                current_frame = 0;
                animationComplite = true;
                firework = null;
                image_location.Clear();



            }
        }


    }
}
