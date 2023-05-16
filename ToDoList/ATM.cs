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
using TextBox = System.Windows.Forms.TextBox;

namespace ToDoList
{
	public partial class ATM : Form
	{
		private Banka bank;
		public ATM()
		{
			InitializeComponent();
			bank = AppData.Bank;
		}

		private void ATM_Load(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Hide();
			new ATMSignUp().ShowDialog();
			this.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (textBox1.Text == "" || textBox2.Text == "")
			{
				MessageBox.Show("Please fill all fields!");
			}
			else
			{
				string passwordFromDb = GetPasswordFromDb(int.Parse(textBox1.Text));
				string password = sha256(textBox2.Text);
				if (passwordFromDb.Equals(password))
				{
					this.Hide();
					new ATMMenu(int.Parse(textBox1.Text), int.Parse(textBox2.Text)).ShowDialog();
					this.Close();
				}
				else
				{
					MessageBox.Show("Wrong account number or password!");
				}
			}
		}

		static string sha256(string randomString)
		{
			var crypt = new System.Security.Cryptography.SHA256Managed();
			var hash = new System.Text.StringBuilder();
			byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(randomString));
			foreach (byte theByte in crypto)
			{
				hash.Append(theByte.ToString("x2"));
			}
			return hash.ToString();
		}

		private string GetPasswordFromDb(int accNumber)
		{
			string server = "localhost";
			string database = "banka";
			string username = "root";
			string password = "";
			string connectionString = $"SERVER={server};DATABASE={database};UID={username};PASSWORD={password};";
			MySqlConnection conn = new MySqlConnection(connectionString);
			conn.Open();
			string query = $"SELECT password FROM racuni WHERE accNumber = '{accNumber}'";
			MySqlCommand cmd = new MySqlCommand(query, conn);
			MySqlDataReader reader = cmd.ExecuteReader();
			string passwordFromDb = "";
			while (reader.Read())
			{
				passwordFromDb = reader.GetString(0);
			}
			conn.Close();
			return passwordFromDb;
		}	
	}
}
