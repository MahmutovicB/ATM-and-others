namespace ToDoList
{
	partial class ATMBalance
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
			balanceLabel = new Label();
			button2 = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
			label1.ForeColor = SystemColors.ControlDarkDark;
			label1.Location = new Point(60, 56);
			label1.Name = "label1";
			label1.Size = new Size(190, 65);
			label1.TabIndex = 5;
			label1.Text = "Balance";
			// 
			// balanceLabel
			// 
			balanceLabel.AutoSize = true;
			balanceLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			balanceLabel.ForeColor = SystemColors.ControlDarkDark;
			balanceLabel.Location = new Point(124, 201);
			balanceLabel.Name = "balanceLabel";
			balanceLabel.Size = new Size(313, 54);
			balanceLabel.TabIndex = 6;
			balanceLabel.Text = "Current balance:";
			// 
			// button2
			// 
			button2.Location = new Point(494, 318);
			button2.Name = "button2";
			button2.Size = new Size(178, 66);
			button2.TabIndex = 13;
			button2.Text = "Back";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// ATMBalance
			// 
			AutoScaleDimensions = new SizeF(13F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(814, 464);
			Controls.Add(button2);
			Controls.Add(balanceLabel);
			Controls.Add(label1);
			Name = "ATMBalance";
			Text = "ATMBalance";
			Load += ATMBalance_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label balanceLabel;
		private Button button2;
	}
}