namespace ToDoList
{
	partial class Paint
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
			panel1 = new Panel();
			button1 = new Button();
			button2 = new Button();
			numericUpDown1 = new NumericUpDown();
			button3 = new Button();
			button4 = new Button();
			button5 = new Button();
			((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.White;
			panel1.BorderStyle = BorderStyle.FixedSingle;
			panel1.Location = new Point(34, 156);
			panel1.Name = "panel1";
			panel1.Size = new Size(2149, 950);
			panel1.TabIndex = 0;
			panel1.MouseDown += panel1_MouseDown;
			panel1.MouseMove += panel1_MouseMove;
			panel1.MouseUp += panel1_MouseUp;
			// 
			// button1
			// 
			button1.Location = new Point(70, 44);
			button1.Name = "button1";
			button1.Size = new Size(150, 46);
			button1.TabIndex = 1;
			button1.Text = "color";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Location = new Point(279, 44);
			button2.Name = "button2";
			button2.Size = new Size(150, 46);
			button2.TabIndex = 2;
			button2.Text = "clear";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// numericUpDown1
			// 
			numericUpDown1.Location = new Point(548, 51);
			numericUpDown1.Name = "numericUpDown1";
			numericUpDown1.Size = new Size(240, 39);
			numericUpDown1.TabIndex = 3;
			numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
			// 
			// button3
			// 
			button3.Location = new Point(2022, 38);
			button3.Name = "button3";
			button3.Size = new Size(161, 62);
			button3.TabIndex = 4;
			button3.Text = "back";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// button4
			// 
			button4.Location = new Point(837, 46);
			button4.Name = "button4";
			button4.Size = new Size(150, 46);
			button4.TabIndex = 5;
			button4.Text = "erase";
			button4.UseVisualStyleBackColor = true;
			button4.Click += button4_Click;
			// 
			// button5
			// 
			button5.Location = new Point(1041, 46);
			button5.Name = "button5";
			button5.Size = new Size(150, 46);
			button5.TabIndex = 6;
			button5.Text = "undo";
			button5.UseVisualStyleBackColor = true;
			button5.Click += button5_Click;
			// 
			// Paint
			// 
			AutoScaleDimensions = new SizeF(13F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(2227, 1213);
			Controls.Add(button5);
			Controls.Add(button4);
			Controls.Add(button3);
			Controls.Add(numericUpDown1);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(panel1);
			Name = "Paint";
			Text = "Paint";
			Load += Paint_Load;
			((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Button button1;
		private Button button2;
		private NumericUpDown numericUpDown1;
		private Button button3;
		private Button button4;
		private Button button5;
	}
}