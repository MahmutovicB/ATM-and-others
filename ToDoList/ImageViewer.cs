using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
	public partial class ImageViewer : Form
	{
		private PictureBox org;
		public ImageViewer()
		{
			InitializeComponent();
		}

		private void ImageViewer_Load(object sender, EventArgs e)
		{
			trackBar1.Minimum = 1;
			trackBar1.Maximum = 6;
			trackBar1.SmallChange = 1;
			trackBar1.LargeChange = 1;
			trackBar1.UseWaitCursor = false;

			this.DoubleBuffered = true;
			org = new PictureBox();
			org.Image = pictureBox1.Image;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Image Files (*.png;*.jpg;*.bmp)|*.png;*.jpg;*.bmp";

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				Image image = Image.FromFile(openFileDialog.FileName);
				pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
				pictureBox1.Image = image;
			}
			org = new PictureBox();
			org.Image = pictureBox1.Image;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			pictureBox1.Image = null;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Hide();
			new MainMenu().ShowDialog();
			this.Close();
		}

		public Banka Banka { get; set; }

		private void button3_Click_1(object sender, EventArgs e)
		{
			this.Hide();
			new MainMenu().ShowDialog();
			this.Close();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			if (pictureBox1.Image != null)
			{
				pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
				pictureBox1.Invalidate();
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			if (trackBar1.Value < 10)
			{ trackBar1.Value++; }
		}

		private void button4_Click(object sender, EventArgs e)
		{
			if (trackBar1.Value > 0)
			{ trackBar1.Value--; }
		}

		private Image Zoom(Image image, Size zoomLevel)
		{
			Bitmap bm = new Bitmap(image, Convert.ToInt32(image.Width * Size.Width),
				Convert.ToInt32(image.Width * Size.Width));
			Graphics gpu = Graphics.FromImage(bm);
			gpu.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
			return bm;
		}


		private void trackBar1_Scroll(object sender, EventArgs e)
		{
			if (trackBar1.Value != 0)
			{
				pictureBox1.Image = null;
				pictureBox1.Image = Zoom(org.Image, new Size(trackBar1.Value, trackBar1.Value));
			}
		}


	}
}
