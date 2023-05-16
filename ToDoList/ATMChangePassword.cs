using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace ToDoList
{
	public partial class ATMChangePassword : Form
	{
		int accountNumber;
		int password;
		private Banka bank;
		public ATMChangePassword(int accountNumber, int password)
		{
			InitializeComponent();
			this.accountNumber = accountNumber;
			this.password = password;
			bank = AppData.Bank;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (textBox2.Text != "" && textBox5.Text != "")
			{
				if (textBox2.Text == textBox5.Text)
				{
					foreach (Racun racun in bank.racuni)
					{
						if (racun.accNumber == accountNumber)
						{
							racun.updatePassword(int.Parse(textBox2.Text));
							MessageBox.Show("Password changed..");
							this.Hide();
							new ATMMenu(accountNumber, password).ShowDialog();
							this.Close();
						}
					}
				}
				else
				{
					MessageBox.Show("Passwords don't match..");
				}
			}
			else
			{
				MessageBox.Show("Please fill all fields..");
			}
		}

		private void ATMChangePassword_Load(object sender, EventArgs e)
		{
			foreach (Racun racun in bank.racuni)
			{
				passwordLabel.Text += racun.getPassword().ToString();
			}
		}
	}
}
