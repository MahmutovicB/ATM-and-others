namespace ToDoList
{
	partial class LoadingScreen
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
			progressBar1 = new ProgressBar();
			txtProgress = new Label();
			button1 = new Button();
			SuspendLayout();
			// 
			// progressBar1
			// 
			progressBar1.ForeColor = Color.ForestGreen;
			progressBar1.Location = new Point(162, 236);
			progressBar1.Name = "progressBar1";
			progressBar1.Size = new Size(453, 46);
			progressBar1.TabIndex = 0;
			progressBar1.Click += progressBar1_Click;
			// 
			// txtProgress
			// 
			txtProgress.Location = new Point(2, 146);
			txtProgress.Name = "txtProgress";
			txtProgress.Size = new Size(796, 57);
			txtProgress.TabIndex = 1;
			txtProgress.Text = "Reading your mind...";
			txtProgress.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// button1
			// 
			button1.Enabled = false;
			button1.Location = new Point(465, 316);
			button1.Name = "button1";
			button1.Size = new Size(150, 46);
			button1.TabIndex = 2;
			button1.Text = "Back";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// LoadingScreen
			// 
			AutoScaleDimensions = new SizeF(13F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(button1);
			Controls.Add(txtProgress);
			Controls.Add(progressBar1);
			Name = "LoadingScreen";
			Text = "Loading Screen";
			Load += LoadingScreen_Load;
			ResumeLayout(false);
		}

		#endregion

		private ProgressBar progressBar1;
		private Label txtProgress;
		private Button button1;
	}
}