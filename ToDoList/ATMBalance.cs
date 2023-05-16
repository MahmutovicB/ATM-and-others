using MySql.Data.MySqlClient;
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
	public partial class ATMBalance : Form
	{
		int accountNumber;
		int password;
		private Banka bank;
		public ATMBalance(int accountNumber, int password)
		{
			InitializeComponent();
			this.accountNumber = accountNumber;
			this.password = password;
			bank = AppData.Bank;
		}

		private void ATMBalance_Load(object sender, EventArgs e)
		{
			double balance = GetBalanceFromDb(accountNumber);
			balanceLabel.Text += " ";
			balanceLabel.Text += balance.ToString();
			balanceLabel.Text += "$";
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

		private void button2_Click(object sender, EventArgs e)
		{
			this.Hide();
			new ATMMenu(accountNumber, password).ShowDialog();
			this.Close();
		}
	}
}
