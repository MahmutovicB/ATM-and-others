namespace ToDoList
{
	partial class ImageViewer
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageViewer));
			pictureBox1 = new PictureBox();
			button1 = new Button();
			button2 = new Button();
			button3 = new Button();
			button4 = new Button();
			button5 = new Button();
			button6 = new Button();
			trackBar1 = new TrackBar();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.BackColor = Color.White;
			pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
			pictureBox1.Location = new Point(424, 158);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(800, 800);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// button1
			// 
			button1.Location = new Point(69, 196);
			button1.Name = "button1";
			button1.Size = new Size(150, 46);
			button1.TabIndex = 1;
			button1.Text = "Browse";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.BackColor = Color.White;
			button2.Location = new Point(69, 279);
			button2.Name = "button2";
			button2.Size = new Size(150, 46);
			button2.TabIndex = 2;
			button2.Text = "Clear";
			button2.UseVisualStyleBackColor = false;
			button2.Click += button2_Click;
			// 
			// button3
			// 
			button3.BackColor = Color.White;
			button3.Location = new Point(1074, 1009);
			button3.Name = "button3";
			button3.Size = new Size(150, 46);
			button3.TabIndex = 3;
			button3.Text = "Back";
			button3.UseVisualStyleBackColor = false;
			button3.Click += button3_Click_1;
			// 
			// button4
			// 
			button4.BackColor = Color.White;
			button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
			button4.BackgroundImageLayout = ImageLayout.Zoom;
			button4.Location = new Point(836, 73);
			button4.Name = "button4";
			button4.Size = new Size(50, 50);
			button4.TabIndex = 4;
			button4.UseVisualStyleBackColor = false;
			button4.Click += button4_Click;
			// 
			// button5
			// 
			button5.BackColor = Color.White;
			button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
			button5.BackgroundImageLayout = ImageLayout.Zoom;
			button5.Location = new Point(767, 73);
			button5.Name = "button5";
			button5.Size = new Size(50, 50);
			button5.TabIndex = 5;
			button5.UseVisualStyleBackColor = false;
			button5.Click += button5_Click;
			// 
			// button6
			// 
			button6.BackColor = Color.White;
			button6.BackgroundImage = (Image)resources.GetObject("button6.BackgroundImage");
			button6.BackgroundImageLayout = ImageLayout.Zoom;
			button6.Location = new Point(908, 73);
			button6.Name = "button6";
			button6.Size = new Size(50, 50);
			button6.TabIndex = 6;
			button6.UseVisualStyleBackColor = false;
			button6.Click += button6_Click;
			// 
			// trackBar1
			// 
			trackBar1.LargeChange = 1;
			trackBar1.Location = new Point(474, 52);
			trackBar1.Name = "trackBar1";
			trackBar1.Size = new Size(255, 90);
			trackBar1.TabIndex = 7;
			// 
			// ImageViewer
			// 
			AutoScaleDimensions = new SizeF(13F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1444, 1134);
			Controls.Add(trackBar1);
			Controls.Add(button6);
			Controls.Add(button5);
			Controls.Add(button4);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(pictureBox1);
			Name = "ImageViewer";
			Text = "ImageViewer";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox pictureBox1;
		private Button button1;
		private Button button2;
		private Button button3;
		private Button button4;
		private Button button5;
		private Button button6;
		private TrackBar trackBar1;
	}
}