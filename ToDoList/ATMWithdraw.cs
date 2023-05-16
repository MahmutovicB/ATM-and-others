using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ToDoList
{
	public partial class ATMWithdraw : Form
	{
		int accountNumber;
		int password;
		private Banka bank;
		public ATMWithdraw(int accountNumber, int password)
		{
			InitializeComponent();
			this.accountNumber = accountNumber;
			this.password = password;
			bank = AppData.Bank;
		}

		private void ATMWithdraw_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			double balanceDb = GetBalanceFromDb(accountNumber);
			double amount = double.Parse(textBox1.Text);
			if (amount > balanceDb)
			{
				MessageBox.Show("You don't have enough money!");
			}
			else
			{
				UpdateBalanceInDb(accountNumber, amount);
				MessageBox.Show("Withdraw completed succesfully!");
				this.Hide();
				new ATMMenu(accountNumber, password).ShowDialog();
				this.Close();
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Hide();
			new ATMMenu(accountNumber, password).ShowDialog();
			this.Close();
		}
		private double GetBalanceFromDb(int accNumber)
		{
			string server = "localhost";
			string database = "banka";
			string username = "root";
			string password = "";
			string connectionString = $"SERVER={server};DATABASE={database};UID={username};PASSWORD={password};";
			MySqlConnection conn = new MySqlConnection(connectionString);
			conn.Open();
			string query = $"SELECT balance FROM racuni WHERE accNumber = '{accNumber}'";
			MySqlCommand cmd = new MySqlCommand(query, conn);
			MySqlDataReader reader = cmd.ExecuteReader();
			string balanceFromDb = "";
			while (reader.Read())
			{
				balanceFromDb = reader.GetString(0);
			}
			conn.Close();
			return double.Parse(balanceFromDb);
		}
		private void UpdateBalanceInDb(int accountNumber, double balance)
		{
			string server = "localhost";
			string database = "banka";
			string username = "root";
			string password = "";
			string connectionString = $"SERVER={server};DATABASE={database};UID={username};PASSWORD={password};";
			MySqlConnection conn = new MySqlConnection(connectionString);
			conn.Open();
			double BalanceFromDb = 0;
			BalanceFromDb = GetBalanceFromDb(accountNumber);

			string query = $"UPDATE racuni SET balance = " + (BalanceFromDb - balance) + " WHERE accNumber = " + accountNumber;
			MySqlCommand cmd = new MySqlCommand(query, conn);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

	}
}
