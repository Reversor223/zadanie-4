using System;
using System.Drawing;
using System.Windows.Forms;

namespace zadanie_4
{
    public partial class Form1 : Form
    {
        private Bitmap loadedImage;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Bitmapy (*.bmp)|*.bmp";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                loadedImage = new Bitmap(dlg.FileName);
                pictureBox1.Image = loadedImage;
            }
        }

        private void btnOnlyGreen_Click(object sender, EventArgs e)
        {
            if (loadedImage == null) return;

            for (int y = 0; y < loadedImage.Height; y++)
            {
                for (int x = 0; x < loadedImage.Width; x++)
                {
                    Color c = loadedImage.GetPixel(x, y);

                    // piksel uznajemy za zielony, jeœli G > R i G > B
                    if (!(c.G > c.R && c.G > c.B))
                    {
                        loadedImage.SetPixel(x, y, Color.Black);
                    }
                }
            }

            pictureBox1.Image = loadedImage;
        }
    }
}
