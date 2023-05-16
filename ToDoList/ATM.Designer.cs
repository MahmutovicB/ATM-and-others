namespace ToDoList
{
	partial class ATM
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
			label2 = new Label();
			label3 = new Label();
			textBox1 = new TextBox();
			textBox2 = new TextBox();
			button2 = new Button();
			button1 = new Button();
			errorMessage = new Label();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
			label1.ForeColor = SystemColors.ControlDarkDark;
			label1.Location = new Point(68, 39);
			label1.Name = "label1";
			label1.Size = new Size(146, 65);
			label1.TabIndex = 1;
			label1.Text = "Login";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label2.ForeColor = SystemColors.ControlDarkDark;
			label2.Location = new Point(76, 158);
			label2.Name = "label2";
			label2.Size = new Size(264, 45);
			label2.TabIndex = 2;
			label2.Text = "Account number:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label3.ForeColor = SystemColors.ControlDarkDark;
			label3.Location = new Point(180, 216);
			label3.Name = "label3";
			label3.Size = new Size(160, 45);
			label3.TabIndex = 3;
			label3.Text = "Password:";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(401, 165);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(212, 39);
			textBox1.TabIndex = 4;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(401, 222);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(212, 39);
			textBox2.TabIndex = 5;
			textBox2.UseSystemPasswordChar = true;
			// 
			// button2
			// 
			button2.Location = new Point(213, 317);
			button2.Name = "button2";
			button2.Size = new Size(178, 66);
			button2.TabIndex = 10;
			button2.Text = "Sign Up";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// button1
			// 
			button1.Location = new Point(397, 317);
			button1.Name = "button1";
			button1.Size = new Size(178, 66);
			button1.TabIndex = 9;
			button1.Text = "Login";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// errorMessage
			// 
			errorMessage.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
			errorMessage.ForeColor = Color.Red;
			errorMessage.Location = new Point(142, 264);
			errorMessage.Name = "errorMessage";
			errorMessage.Size = new Size(471, 35);
			errorMessage.TabIndex = 11;
			errorMessage.TextAlign = ContentAlignment.BottomRight;
			// 
			// ATM
			// 
			AutoScaleDimensions = new SizeF(13F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(errorMessage);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "ATM";
			Text = "ATM";
			Load += ATM_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private TextBox textBox1;
		private TextBox textBox2;
		private Button button2;
		private Button button1;
		private Label errorMessage;
	}
}