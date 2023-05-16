using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ToDoList
{
	public partial class ToDoList : Form
	{
		public ToDoList()
		{
			InitializeComponent();
		}

		private void BtnAdd_Click(object sender, EventArgs e)
		{
			if (textBox.Text != "")
			{
				taskList.Items.Add(textBox.Text);
				textBox.Text = "";
			}
		}

		private void taskList_Click(object sender, EventArgs e)
		{

		}

		private void ToDoList_Load(object sender, EventArgs e)
		{

		}

		private void taskList_DoubleClick(object sender, EventArgs e)
		{
			if (taskList.Items.Count > 0 && taskList.SelectedIndex != -1)
			{
				taskList.Items.RemoveAt(taskList.SelectedIndex);
			}
		}

		private void textBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				if (textBox.Text != "")
				{
					taskList.Items.Add(textBox.Text);
					textBox.Text = "";
				}
			}
		}

		private void BtnBack_Click(object sender, EventArgs e)
		{
			this.Hide();
			new MainMenu().ShowDialog();
			this.Close();
		}
	}
}
