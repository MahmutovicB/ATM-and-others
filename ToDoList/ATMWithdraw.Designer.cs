namespace ToDoList
{
	partial class ATMWithdraw
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
			button2 = new Button();
			button1 = new Button();
			textBox1 = new TextBox();
			label2 = new Label();
			label1 = new Label();
			SuspendLayout();
			// 
			// button2
			// 
			button2.Location = new Point(214, 360);
			button2.Name = "button2";
			button2.Size = new Size(178, 66);
			button2.TabIndex = 17;
			button2.Text = "Back";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// button1
			// 
			button1.Location = new Point(398, 360);
			button1.Name = "button1";
			button1.Size = new Size(178, 66);
			button1.TabIndex = 16;
			button1.Text = "Confirm";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// textBox1
			// 
			textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			textBox1.Location = new Point(398, 245);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(212, 50);
			textBox1.TabIndex = 15;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			label2.ForeColor = SystemColors.ControlDarkDark;
			label2.Location = new Point(176, 241);
			label2.Name = "label2";
			label2.Size = new Size(203, 54);
			label2.TabIndex = 14;
			label2.Text = "Withdraw:";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
			label1.ForeColor = SystemColors.ControlDarkDark;
			label1.Location = new Point(53, 27);
			label1.Name = "label1";
			label1.Size = new Size(191, 65);
			label1.TabIndex = 13;
			label1.Text = "Deposit";
			// 
			// ATMWithdraw
			// 
			AutoScaleDimensions = new SizeF(13F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(814, 553);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(textBox1);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "ATMWithdraw";
			Text = "ATMWithdraw";
			Load += ATMWithdraw_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button button2;
		private Button button1;
		private TextBox textBox1;
		private Label label2;
		private Label label1;
	}
}