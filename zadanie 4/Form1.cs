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

        private void btnRotate90_Click(object sender, EventArgs e)
        {
            if (loadedImage == null) return;

            loadedImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox1.Image = loadedImage;
        }

        private void btnRotate180_Click(object sender, EventArgs e)
        {
            if (loadedImage == null) return;

            loadedImage.RotateFlip(RotateFlipType.Rotate180FlipNone);
            pictureBox1.Image = loadedImage;
        }

        private void btnRotate270_Click(object sender, EventArgs e)
        {
            if (loadedImage == null) return;

            loadedImage.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pictureBox1.Image = loadedImage;
        }

        private void btnInvert_Click(object sender, EventArgs e)
        {
            if (loadedImage == null) return;

            for (int y = 0; y < loadedImage.Height; y++)
            {
                for (int x = 0; x < loadedImage.Width; x++)
                {
                    Color c = loadedImage.GetPixel(x, y);
                    Color inverted = Color.FromArgb(255 - c.R, 255 - c.G, 255 - c.B);
                    loadedImage.SetPixel(x, y, inverted);
                }
            }

            pictureBox1.Image = loadedImage;
        }

        private void btnUpsideDown_Click(object sender, EventArgs e)
        {
            if (loadedImage == null) return;

            loadedImage.RotateFlip(RotateFlipType.RotateNoneFlipY);
            pictureBox1.Image = loadedImage;
        }


    }
}
