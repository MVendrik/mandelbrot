using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mandelbrot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.SelectedIndex = 0;

        }
        private void pas_aan(object sender, System.EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_OK_Click(object sender, EventArgs e)
        {

        }

        private void bitmap_image(object obj, PaintEventArgs pea)
        {
            Graphics gr = pea.Graphics;
            Bitmap bm;
            bm = new Bitmap(400, 400);
            gr.DrawImage(bm, 200, 100);

            for (int x = 0; x < bm.Width; x++)
            {
                for (int y = 0; y < bm.Height; y++)
                {
                    bm.SetPixel(x, y, Color.Red);
                }
            }
            pictureBox_forBM.BackgroundImage = bm;
            pictureBox_forBM.Size = bm.Size;
        }
    }
}
