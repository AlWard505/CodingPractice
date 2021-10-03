using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17_WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int width = 640;
            int height = 480;

            Bitmap bmp = new Bitmap(width, height);
            Random RandomRGB = new Random();
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    bmp.SetPixel(x, y, Color.FromArgb(255, RandomRGB.Next(0,255), RandomRGB.Next(0, 255), RandomRGB.Next(0, 255)));
                }
            }
            pictureBox1.Image = bmp;
        }
    }
}
