namespace zadanie_4
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnRotate90 = new System.Windows.Forms.Button();
            this.btnRotate180 = new System.Windows.Forms.Button();
            this.btnRotate270 = new System.Windows.Forms.Button();
            this.btnInvert = new System.Windows.Forms.Button();
            this.btnUpsideDown = new System.Windows.Forms.Button();
            this.btnOnlyGreen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();

            // pictureBox1
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Size = new System.Drawing.Size(600, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            // btnLoad
            this.btnLoad.Location = new System.Drawing.Point(630, 20);
            this.btnLoad.Size = new System.Drawing.Size(140, 30);
            this.btnLoad.Text = "Load Image";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);

           

            // Form1
            this.ClientSize = new System.Drawing.Size(800, 430);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnRotate90);
            this.Controls.Add(this.btnRotate180);
            this.Controls.Add(this.btnRotate270);
            this.Controls.Add(this.btnInvert);
            this.Controls.Add(this.btnUpsideDown);
            this.Controls.Add(this.btnOnlyGreen);
            this.Text = "Image Editor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnRotate90;
        private System.Windows.Forms.Button btnRotate180;
        private System.Windows.Forms.Button btnRotate270;
        private System.Windows.Forms.Button btnInvert;
        private System.Windows.Forms.Button btnUpsideDown;
        private System.Windows.Forms.Button btnOnlyGreen;
    }
}