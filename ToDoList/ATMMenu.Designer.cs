namespace ToDoList
{
	partial class ATMMenu
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
			accountNumLabel = new Label();
			button1 = new Button();
			button2 = new Button();
			button3 = new Button();
			button4 = new Button();
			button5 = new Button();
			backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
			label1.ForeColor = SystemColors.ControlDarkDark;
			label1.Location = new Point(56, 49);
			label1.Name = "label1";
			label1.Size = new Size(259, 65);
			label1.TabIndex = 3;
			label1.Text = "ATM Menu";
			// 
			// accountNumLabel
			// 
			accountNumLabel.AutoSize = true;
			accountNumLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			accountNumLabel.ForeColor = SystemColors.ControlDarkDark;
			accountNumLabel.Location = new Point(56, 130);
			accountNumLabel.Name = "accountNumLabel";
			accountNumLabel.Size = new Size(327, 54);
			accountNumLabel.TabIndex = 4;
			accountNumLabel.Text = "Account number:";
			// 
			// button1
			// 
			button1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			button1.ForeColor = SystemColors.ControlDarkDark;
			button1.Location = new Point(183, 294);
			button1.Name = "button1";
			button1.Size = new Size(287, 122);
			button1.TabIndex = 10;
			button1.Text = "Deposit";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			button2.ForeColor = SystemColors.ControlDarkDark;
			button2.Location = new Point(658, 294);
			button2.Name = "button2";
			button2.Size = new Size(287, 122);
			button2.TabIndex = 11;
			button2.Text = "Withdraw";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// button3
			// 
			button3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			button3.ForeColor = SystemColors.ControlDarkDark;
			button3.Location = new Point(658, 450);
			button3.Name = "button3";
			button3.Size = new Size(287, 122);
			button3.TabIndex = 13;
			button3.Text = "Change password";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// button4
			// 
			button4.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			button4.ForeColor = SystemColors.ControlDarkDark;
			button4.Location = new Point(183, 450);
			button4.Name = "button4";
			button4.Size = new Size(287, 122);
			button4.TabIndex = 12;
			button4.Text = "Balance";
			button4.UseVisualStyleBackColor = true;
			button4.Click += button4_Click;
			// 
			// button5
			// 
			button5.Location = new Point(903, 58);
			button5.Name = "button5";
			button5.Size = new Size(178, 66);
			button5.TabIndex = 14;
			button5.Text = "Log out";
			button5.UseVisualStyleBackColor = true;
			button5.Click += button5_Click;
			// 
			// ATMMenu
			// 
			AutoScaleDimensions = new SizeF(13F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1159, 712);
			Controls.Add(button5);
			Controls.Add(button3);
			Controls.Add(button4);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(accountNumLabel);
			Controls.Add(label1);
			Name = "ATMMenu";
			Text = "ATMMenu";
			Load += ATMMenu_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label accountNumLabel;
		private Button button1;
		private Button button2;
		private Button button3;
		private Button button4;
		private Button button5;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
	}
}