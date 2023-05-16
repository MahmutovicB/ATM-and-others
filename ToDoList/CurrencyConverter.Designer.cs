namespace ToDoList
{
	partial class CurrencyConverter
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
			label4 = new Label();
			textBox1 = new TextBox();
			comboBox1 = new ComboBox();
			comboBox2 = new ComboBox();
			button1 = new Button();
			button2 = new Button();
			label5 = new Label();
			resultText = new Label();
			index = new Label();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
			label1.ForeColor = SystemColors.ControlDarkDark;
			label1.Location = new Point(103, 60);
			label1.Name = "label1";
			label1.Size = new Size(429, 65);
			label1.TabIndex = 0;
			label1.Text = "Currency converter";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label2.ForeColor = SystemColors.ControlDarkDark;
			label2.Location = new Point(131, 187);
			label2.Name = "label2";
			label2.Size = new Size(142, 45);
			label2.TabIndex = 1;
			label2.Text = "Amount:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label3.ForeColor = SystemColors.ControlDarkDark;
			label3.Location = new Point(172, 262);
			label3.Name = "label3";
			label3.Size = new Size(101, 45);
			label3.TabIndex = 2;
			label3.Text = "From:";
			label3.Click += label3_Click;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label4.ForeColor = SystemColors.ControlDarkDark;
			label4.Location = new Point(213, 332);
			label4.Name = "label4";
			label4.Size = new Size(60, 45);
			label4.TabIndex = 3;
			label4.Text = "To:";
			// 
			// textBox1
			// 
			textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			textBox1.Location = new Point(298, 190);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(246, 50);
			textBox1.TabIndex = 4;
			textBox1.TextAlign = HorizontalAlignment.Right;
			// 
			// comboBox1
			// 
			comboBox1.FormattingEnabled = true;
			comboBox1.Items.AddRange(new object[] { "BAM", "USD", "EUR" });
			comboBox1.Location = new Point(302, 269);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(242, 40);
			comboBox1.TabIndex = 5;
			// 
			// comboBox2
			// 
			comboBox2.FormattingEnabled = true;
			comboBox2.Items.AddRange(new object[] { "BAM", "USD", "EUR" });
			comboBox2.Location = new Point(302, 339);
			comboBox2.Name = "comboBox2";
			comboBox2.Size = new Size(242, 40);
			comboBox2.TabIndex = 6;
			comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
			// 
			// button1
			// 
			button1.Location = new Point(302, 568);
			button1.Name = "button1";
			button1.Size = new Size(178, 66);
			button1.TabIndex = 7;
			button1.Text = "Convert";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Location = new Point(118, 568);
			button2.Name = "button2";
			button2.Size = new Size(178, 66);
			button2.TabIndex = 8;
			button2.Text = "Back";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(28, 187);
			label5.Name = "label5";
			label5.Size = new Size(0, 32);
			label5.TabIndex = 9;
			// 
			// resultText
			// 
			resultText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			resultText.ForeColor = SystemColors.ControlDarkDark;
			resultText.Location = new Point(12, 422);
			resultText.Name = "resultText";
			resultText.Size = new Size(590, 45);
			resultText.TabIndex = 10;
			resultText.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// index
			// 
			index.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			index.ForeColor = SystemColors.ControlDarkDark;
			index.Location = new Point(12, 485);
			index.Name = "index";
			index.Size = new Size(590, 45);
			index.TabIndex = 11;
			index.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// CurrencyConverter
			// 
			AutoScaleDimensions = new SizeF(13F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(614, 673);
			Controls.Add(index);
			Controls.Add(resultText);
			Controls.Add(label5);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(comboBox2);
			Controls.Add(comboBox1);
			Controls.Add(textBox1);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "CurrencyConverter";
			Text = "CurrencyConverter";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private TextBox textBox1;
		private ComboBox comboBox1;
		private ComboBox comboBox2;
		private Button button1;
		private Button button2;
		private Label label5;
		private Label resultText;
		private Label index;
	}
}