using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PenCit10_Color_Detection
{
    public partial class Form1 : Form
    {
        Bitmap bitmap1;
        Bitmap bitmap2;
        Bitmap bitmap3;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult d = openFileDialog1.ShowDialog();
            if (d == DialogResult.OK)
            {
                bitmap1 = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = bitmap1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bitmap2 = new Bitmap(bitmap1);
            int r = int.Parse(textBox1.Text);
            int g = int.Parse(textBox2.Text);
            int b = int.Parse(textBox3.Text);
            int maxD = int.Parse(textBox4.Text);
            for (int x = 0; x < bitmap1.Width; x++)
            {
                for (int y = 0; y < bitmap1.Height; y++)
                {
                    Color w = bitmap1.GetPixel(x, y);
                    Color wb;
                    double d = Math.Abs(w.R - r) + Math.Abs(w.G - g) + Math.Abs(w.B - b);
                    if (d < maxD)
                    {
                        wb = w;
                    }
                    else
                    {
                        wb = Color.FromArgb(0, 0, 0);
                    }
                    bitmap2.SetPixel(x, y, wb);
                }
            }
            pictureBox2.Image = bitmap2;
        }

        private void button3_Click(object sender, EventArgs e)
           {
            bitmap3 = new Bitmap(bitmap1);
            int r = int.Parse(textBox7.Text);
            int g = int.Parse(textBox8.Text);
            int b = int.Parse(textBox9.Text);
            int maxD = int.Parse(textBox10.Text);
            for (int x = 0; x < bitmap1.Width; x++)
            {
                for (int y = 0; y < bitmap1.Height; y++)
                {
                    Color w = bitmap1.GetPixel(x, y);
                    Color wb;
                    double d = Math.Abs(w.R - r) + Math.Abs(w.G - g) + Math.Abs(w.B - b);
                    if (d < maxD)
                    {
                        wb = w;
                    }
                    else
                    {
                        wb = Color.FromArgb(0, 0, 0);
                    }
                    bitmap3.SetPixel(x, y, wb);
                }
            }
            pictureBox3.Image = bitmap3;
        }
    }
}
