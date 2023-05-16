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
	public partial class CurrencyConverter : Form
	{
		private Dictionary<string, double> fromBAM = new Dictionary<string, double>();
		private Dictionary<string, double> fromUSD = new Dictionary<string, double>();
		private Dictionary<string, double> fromEUR = new Dictionary<string, double>();

		private void init()
		{
			fromBAM.Add("BAM", 1);
			fromBAM.Add("USD", 0.61);
			fromBAM.Add("EUR", 0.51);
			fromUSD.Add("BAM", 1.64);
			fromUSD.Add("USD", 1);
			fromUSD.Add("EUR", 0.84);
			fromEUR.Add("BAM", 1.96);
			fromEUR.Add("USD", 1.19);
			fromEUR.Add("EUR", 1);
		}

		public CurrencyConverter()
		{
			InitializeComponent();
			comboBox1.SelectedIndex = 0;
			comboBox2.SelectedIndex = 1;
			init();
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Hide();
			new MainMenu().ShowDialog();
			this.Close();
		}

		public Banka Banka { get; set; }

		private void button1_Click(object sender, EventArgs e)
		{
			double amount = double.Parse(textBox1.Text);
			double result = 0;
			if (comboBox1.SelectedItem.ToString() == "BAM")
			{
				result = amount * fromBAM[comboBox2.SelectedItem.ToString()];
				index.Text = $"1 {comboBox1.SelectedItem.ToString()} = {fromBAM[comboBox2.SelectedItem.ToString()]} {comboBox2.SelectedItem.ToString()}";
			}
			else if (comboBox1.SelectedItem.ToString() == "USD")
			{
				result = amount * fromUSD[comboBox2.SelectedItem.ToString()];
				index.Text = $"1 {comboBox1.SelectedItem.ToString()} = {fromUSD[comboBox2.SelectedItem.ToString()]} {comboBox2.SelectedItem.ToString()}";
			}
			else if (comboBox1.SelectedItem.ToString() == "EUR")
			{
				result = amount * fromEUR[comboBox2.SelectedItem.ToString()];
				index.Text = $"1 {comboBox1.SelectedItem.ToString()} = {fromEUR[comboBox2.SelectedItem.ToString()]} {comboBox2.SelectedItem.ToString()}";
			}

			resultText.Text = $"{amount} {comboBox1.SelectedItem.ToString()} = {result} {comboBox1.SelectedItem.ToString()}";

		}
	}
}
