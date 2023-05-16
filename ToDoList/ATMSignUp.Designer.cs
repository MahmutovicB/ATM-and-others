namespace ToDoList
{
	partial class ATMSignUp
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
			textBox2 = new TextBox();
			textBox1 = new TextBox();
			label3 = new Label();
			label2 = new Label();
			textBox3 = new TextBox();
			label4 = new Label();
			textBox4 = new TextBox();
			label5 = new Label();
			button2 = new Button();
			button1 = new Button();
			textBox5 = new TextBox();
			label6 = new Label();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
			label1.ForeColor = SystemColors.ControlDarkDark;
			label1.Location = new Point(76, 51);
			label1.Name = "label1";
			label1.Size = new Size(195, 65);
			label1.TabIndex = 2;
			label1.Text = "Sign Up";
			// 
			// textBox2
			// 
			textBox2.Location = new Point(565, 339);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(212, 39);
			textBox2.TabIndex = 9;
			textBox2.UseSystemPasswordChar = true;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(565, 151);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(212, 39);
			textBox1.TabIndex = 8;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label3.ForeColor = SystemColors.ControlDarkDark;
			label3.Location = new Point(344, 333);
			label3.Name = "label3";
			label3.Size = new Size(160, 45);
			label3.TabIndex = 7;
			label3.Text = "Password:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label2.ForeColor = SystemColors.ControlDarkDark;
			label2.Location = new Point(240, 144);
			label2.Name = "label2";
			label2.Size = new Size(264, 45);
			label2.TabIndex = 6;
			label2.Text = "Account number:";
			// 
			// textBox3
			// 
			textBox3.Location = new Point(565, 213);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(212, 39);
			textBox3.TabIndex = 11;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label4.ForeColor = SystemColors.ControlDarkDark;
			label4.Location = new Point(392, 206);
			label4.Name = "label4";
			label4.Size = new Size(112, 45);
			label4.TabIndex = 10;
			label4.Text = "Name:";
			// 
			// textBox4
			// 
			textBox4.Location = new Point(565, 277);
			textBox4.Name = "textBox4";
			textBox4.Size = new Size(212, 39);
			textBox4.TabIndex = 13;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label5.ForeColor = SystemColors.ControlDarkDark;
			label5.Location = new Point(352, 270);
			label5.Name = "label5";
			label5.Size = new Size(152, 45);
			label5.TabIndex = 12;
			label5.Text = "Surname:";
			// 
			// button2
			// 
			button2.Location = new Point(566, 515);
			button2.Name = "button2";
			button2.Size = new Size(178, 66);
			button2.TabIndex = 15;
			button2.Text = "Back";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// button1
			// 
			button1.Location = new Point(750, 515);
			button1.Name = "button1";
			button1.Size = new Size(178, 66);
			button1.TabIndex = 14;
			button1.Text = "Sign Up";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// textBox5
			// 
			textBox5.Location = new Point(565, 401);
			textBox5.Name = "textBox5";
			textBox5.Size = new Size(212, 39);
			textBox5.TabIndex = 17;
			textBox5.UseSystemPasswordChar = true;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label6.ForeColor = SystemColors.ControlDarkDark;
			label6.Location = new Point(210, 401);
			label6.Name = "label6";
			label6.Size = new Size(294, 45);
			label6.TabIndex = 16;
			label6.Text = "Confirm password: ";
			// 
			// ATMSignUp
			// 
			AutoScaleDimensions = new SizeF(13F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1104, 614);
			Controls.Add(textBox5);
			Controls.Add(label6);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(textBox4);
			Controls.Add(label5);
			Controls.Add(textBox3);
			Controls.Add(label4);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "ATMSignUp";
			Text = "ATMSignUp";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox textBox2;
		private TextBox textBox1;
		private Label label3;
		private Label label2;
		private TextBox textBox3;
		private Label label4;
		private TextBox textBox4;
		private Label label5;
		private Button button2;
		private Button button1;
		private TextBox textBox5;
		private Label label6;
	}
}