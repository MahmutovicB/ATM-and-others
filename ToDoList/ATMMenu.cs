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
	public partial class ATMMenu : Form
	{
		public int accountNumber;
		public int password;

		public ATMMenu(int accountNumber, int password)
		{
			InitializeComponent();
			this.accountNumber = accountNumber;
			this.password = password;
		}

		private void ATMMenu_Load(object sender, EventArgs e)
		{
			accountNumLabel.Text += " ";
			accountNumLabel.Text += accountNumber.ToString();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			this.Hide();
			new ATM().ShowDialog();
			this.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			new ATMDeposit(accountNumber, password).ShowDialog();
			this.Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Hide();
			new ATMWithdraw(accountNumber, password).ShowDialog();
			this.Close();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			this.Hide();
			new ATMBalance(accountNumber, password).ShowDialog();
			this.Close();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Hide();
			new ATMChangePassword(accountNumber, password).ShowDialog();
			this.Close();
		}
	}
}
