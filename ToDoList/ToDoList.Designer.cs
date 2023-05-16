namespace ToDoList
{
	partial class ToDoList
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
			textBox = new TextBox();
			BtnAdd = new Button();
			taskList = new ListBox();
			BtnBack = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
			label1.ForeColor = SystemColors.ControlDarkDark;
			label1.Location = new Point(126, 41);
			label1.Name = "label1";
			label1.Size = new Size(235, 65);
			label1.TabIndex = 0;
			label1.Text = "To Do List";
			// 
			// textBox
			// 
			textBox.Location = new Point(126, 130);
			textBox.Name = "textBox";
			textBox.Size = new Size(464, 39);
			textBox.TabIndex = 1;
			textBox.KeyDown += textBox_KeyDown;
			// 
			// BtnAdd
			// 
			BtnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			BtnAdd.ForeColor = SystemColors.ActiveCaptionText;
			BtnAdd.Location = new Point(747, 123);
			BtnAdd.Name = "BtnAdd";
			BtnAdd.Size = new Size(150, 46);
			BtnAdd.TabIndex = 2;
			BtnAdd.Text = "add";
			BtnAdd.UseVisualStyleBackColor = true;
			BtnAdd.Click += BtnAdd_Click;
			// 
			// taskList
			// 
			taskList.FormattingEnabled = true;
			taskList.ItemHeight = 32;
			taskList.Location = new Point(133, 226);
			taskList.Name = "taskList";
			taskList.Size = new Size(461, 260);
			taskList.TabIndex = 3;
			taskList.Click += taskList_Click;
			taskList.DoubleClick += taskList_DoubleClick;
			// 
			// BtnBack
			// 
			BtnBack.Location = new Point(747, 440);
			BtnBack.Name = "BtnBack";
			BtnBack.Size = new Size(150, 46);
			BtnBack.TabIndex = 4;
			BtnBack.Text = "back";
			BtnBack.UseVisualStyleBackColor = true;
			BtnBack.Click += BtnBack_Click;
			// 
			// ToDoList
			// 
			AutoScaleDimensions = new SizeF(13F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1050, 581);
			Controls.Add(BtnBack);
			Controls.Add(taskList);
			Controls.Add(BtnAdd);
			Controls.Add(textBox);
			Controls.Add(label1);
			Name = "ToDoList";
			Text = "ToDoList";
			Load += ToDoList_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox textBox;
		private Button BtnAdd;
		private ListBox taskList;
		private Button BtnBack;
	}
}