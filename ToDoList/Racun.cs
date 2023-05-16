using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
	public class Racun
	{
		public int accNumber;
		private int password;
		private double balance;
		private string name;
		private string surname;

		public Racun(int accNumber, int password, double balance, string name, string surname)
		{
			this.accNumber = accNumber;
			this.password = password;
			this.balance = balance;
			this.name = name;
			this.surname = surname;
		}

		public int getPassword()
		{
			return this.password;
		}

		public void deposit(double amount)
		{
			this.balance += amount;
		}

		public string getBalance()
		{
			return this.balance.ToString();
		}

		public void updateBalance(double amount)
		{
			this.balance -= amount;
		}

		public void updatePassword(int password)
		{
			this.password = password;
		}
	}
}
