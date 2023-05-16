using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
	public partial class MindReader : Form
	{
		private decimal value;
		public MindReader()
		{
			InitializeComponent();
		}

		public decimal Value
		{
			get { return value; }
		}

		private void btnConfirm_Click(object sender, EventArgs e)
		{
			value = NUDNumber.Value;
			this.Hide();
			new LoadingScreen(value).ShowDialog();
			this.Close();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Hide();
			new MainMenu().ShowDialog();
			this.Close();
		}
	}
}
