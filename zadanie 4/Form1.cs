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

    }
}
