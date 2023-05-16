namespace ToDoList
{
	partial class ATMChangePassword
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
			textBox5 = new TextBox();
			label6 = new Label();
			textBox2 = new TextBox();
			label3 = new Label();
			button2 = new Button();
			button1 = new Button();
			label1 = new Label();
			passwordLabel = new Label();
			SuspendLayout();
			// 
			// textBox5
			// 
			textBox5.Location = new Point(492, 303);
			textBox5.Name = "textBox5";
			textBox5.Size = new Size(212, 39);
			textBox5.TabIndex = 21;
			textBox5.UseSystemPasswordChar = true;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label6.ForeColor = SystemColors.ControlDarkDark;
			label6.Location = new Point(146, 296);
			label6.Name = "label6";
			label6.Size = new Size(285, 45);
			label6.TabIndex = 20;
			label6.Text = "Confirm password:";
			// 
			// textBox2
			// 
			textBox2.Location = new Point(492, 241);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(212, 39);
			textBox2.TabIndex = 19;
			textBox2.UseSystemPasswordChar = true;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label3.ForeColor = SystemColors.ControlDarkDark;
			label3.Location = new Point(196, 234);
			label3.Name = "label3";
			label3.Size = new Size(235, 45);
			label3.TabIndex = 18;
			label3.Text = "New password:";
			// 
			// button2
			// 
			button2.Location = new Point(287, 405);
			button2.Name = "button2";
			button2.Size = new Size(178, 66);
			button2.TabIndex = 23;
			button2.Text = "Back";
			button2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			button1.Location = new Point(471, 405);
			button1.Name = "button1";
			button1.Size = new Size(178, 66);
			button1.TabIndex = 22;
			button1.Text = "Confirm";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
			label1.ForeColor = SystemColors.ControlDarkDark;
			label1.Location = new Point(91, 79);
			label1.Name = "label1";
			label1.Size = new Size(402, 65);
			label1.TabIndex = 24;
			label1.Text = "Change password";
			// 
			// passwordLabel
			// 
			passwordLabel.AutoSize = true;
			passwordLabel.Enabled = false;
			passwordLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			passwordLabel.ForeColor = SystemColors.ControlDarkDark;
			passwordLabel.Location = new Point(104, 144);
			passwordLabel.Name = "passwordLabel";
			passwordLabel.Size = new Size(169, 45);
			passwordLabel.TabIndex = 25;
			passwordLabel.Text = "Password: ";
			// 
			// ATMChangePassword
			// 
			AutoScaleDimensions = new SizeF(13F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(923, 580);
			Controls.Add(passwordLabel);
			Controls.Add(label1);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(textBox5);
			Controls.Add(label6);
			Controls.Add(textBox2);
			Controls.Add(label3);
			Name = "ATMChangePassword";
			Text = "ATMChangePassword";
			Load += ATMChangePassword_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBox5;
		private Label label6;
		private TextBox textBox2;
		private Label label3;
		private Button button2;
		private Button button1;
		private Label label1;
		private Label passwordLabel;
	}
}