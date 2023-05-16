namespace ToDoList
{
	partial class ATMDeposit
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
			textBox1 = new TextBox();
			label2 = new Label();
			button2 = new Button();
			button1 = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
			label1.ForeColor = SystemColors.ControlDarkDark;
			label1.Location = new Point(53, 39);
			label1.Name = "label1";
			label1.Size = new Size(191, 65);
			label1.TabIndex = 4;
			label1.Text = "Deposit";
			// 
			// textBox1
			// 
			textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			textBox1.Location = new Point(398, 257);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(212, 50);
			textBox1.TabIndex = 6;
			textBox1.TextChanged += textBox1_TextChanged;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			label2.ForeColor = SystemColors.ControlDarkDark;
			label2.Location = new Point(194, 243);
			label2.Name = "label2";
			label2.Size = new Size(175, 54);
			label2.TabIndex = 5;
			label2.Text = "Amount:";
			label2.Click += label2_Click;
			// 
			// button2
			// 
			button2.Location = new Point(214, 372);
			button2.Name = "button2";
			button2.Size = new Size(178, 66);
			button2.TabIndex = 12;
			button2.Text = "Back";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// button1
			// 
			button1.Location = new Point(398, 372);
			button1.Name = "button1";
			button1.Size = new Size(178, 66);
			button1.TabIndex = 11;
			button1.Text = "Confirm";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// ATMDeposit
			// 
			AutoScaleDimensions = new SizeF(13F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(835, 569);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(textBox1);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "ATMDeposit";
			Text = "ATMDeposit";
			Load += ATMDeposit_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox textBox1;
		private Label label2;
		private Button button2;
		private Button button1;
	}
}