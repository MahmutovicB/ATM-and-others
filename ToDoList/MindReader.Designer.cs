namespace ToDoList
{
	partial class MindReader
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
			label1 = new Label();
			btnConfirm = new Button();
			btnBack = new Button();
			NUDNumber = new NumericUpDown();
			((System.ComponentModel.ISupportInitialize)NUDNumber).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(245, 162);
			label1.Name = "label1";
			label1.Size = new Size(339, 32);
			label1.TabIndex = 0;
			label1.Text = "What number is in your mind?";
			// 
			// btnConfirm
			// 
			btnConfirm.Location = new Point(434, 309);
			btnConfirm.Name = "btnConfirm";
			btnConfirm.Size = new Size(150, 46);
			btnConfirm.TabIndex = 2;
			btnConfirm.Text = "Confirm";
			btnConfirm.UseVisualStyleBackColor = true;
			btnConfirm.Click += btnConfirm_Click;
			// 
			// btnBack
			// 
			btnBack.Location = new Point(258, 309);
			btnBack.Name = "btnBack";
			btnBack.Size = new Size(150, 46);
			btnBack.TabIndex = 3;
			btnBack.Text = "Back";
			btnBack.UseVisualStyleBackColor = true;
			btnBack.Click += btnBack_Click;
			// 
			// NUDNumber
			// 
			NUDNumber.Location = new Point(377, 224);
			NUDNumber.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
			NUDNumber.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			NUDNumber.Name = "NUDNumber";
			NUDNumber.Size = new Size(106, 39);
			NUDNumber.TabIndex = 4;
			NUDNumber.TextAlign = HorizontalAlignment.Right;
			NUDNumber.Value = new decimal(new int[] { 1, 0, 0, 0 });
			// 
			// MindReader
			// 
			AutoScaleDimensions = new SizeF(13F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(877, 505);
			Controls.Add(NUDNumber);
			Controls.Add(btnBack);
			Controls.Add(btnConfirm);
			Controls.Add(label1);
			Name = "MindReader";
			Text = "Mind Reader";
			((System.ComponentModel.ISupportInitialize)NUDNumber).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Button btnConfirm;
		private Button btnBack;
		private NumericUpDown NUDNumber;
	}
}