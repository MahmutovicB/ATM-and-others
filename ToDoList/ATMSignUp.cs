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
	public partial class ATMSignUp : Form
	{
		private Banka bank;
		public ATMSignUp()
		{
			InitializeComponent();
			bank = AppData.Bank;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Hide();
			new ATM().ShowDialog();
			this.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
			{
				MessageBox.Show("Please fill all fields!");
			}
			else
			{
				if (textBox2.Text != textBox5.Text)
				{
					MessageBox.Show("Passwords do not match!");
				}
				else
				{
					MessageBox.Show("Account created successfully!");
					Racun temp = new Racun(int.Parse(textBox1.Text), int.Parse(textBox2.Text), 0, textBox3.Text, textBox4.Text);
					bank.addRacun(temp);
					string server = "localhost";
					string database = "banka";
					string username = "root";
					string password = "";
					string connectionString = $"SERVER={server};DATABASE={database};UID={username};PASSWORD={password};";
					MySqlConnection conn = new MySqlConnection(connectionString);
					conn.Open();
					string query = $"INSERT INTO racuni (accNumber, password, balance, name, surname) VALUES ('{textBox1.Text}', '{sha256(textBox2.Text)}', '{0}', '{textBox3.Text}', '{textBox4.Text}')";
					MySqlCommand cmd = new MySqlCommand(query, conn);
					cmd.ExecuteNonQuery();
					conn.Close();

					this.Hide();
					new ATM().ShowDialog();
					this.Close();
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

	}


}
