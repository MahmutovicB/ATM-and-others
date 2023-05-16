using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ToDoList
{
	public partial class LoadingScreen : Form
	{
		private decimal val;
		public LoadingScreen(decimal value)
		{
			InitializeComponent();
			val = value;
		}

		private void progressBar1_Click(object sender, EventArgs e)
		{

		}

		private void LoadingScreen_Load(object sender, EventArgs e)
		{
			// Set the initial value of the progress bar
			progressBar1.Value = 0;

			// Start loading data in a background thread
			Task.Run(() => LoadData());
		}


		private void LoadData()
		{
			// Simulate a long loading process on app startup.
			for (int i = 0; i <= 100; i++)
			{
				// Report progress to 'UI' thread
				Invoke(new Action(() => progressBar1.Value = i));
				// Simulate long task
				System.Threading.Thread.Sleep(100);
				if (i == 100)
				{
					progressBar1.Hide();
					button1.Enabled = true;
					txtProgress.Text = $"The number that you are thinking of is... {val}";
				}
			}

		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			new MindReader().ShowDialog();
			this.Close();
		}
	}



}
