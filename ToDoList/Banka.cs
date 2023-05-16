using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
	public class Banka
	{
		public List<Racun> racuni = new List<Racun>();

		public Banka()
		{
			racuni = new List<Racun>();
		}

		public Racun getRacun(int accNumber)
		{
			foreach (Racun r in racuni)
			{
				if (r.accNumber == accNumber)
				{
					return r;
				}
			}
			return null;
		}

		public void addRacun(Racun r)
		{
			racuni.Add(r);
		}

		public void removeRacun(Racun r)
		{
			racuni.Remove(r);
		}

		public bool checkRacun(int accNumber, int password)
		{
			Racun temp = getRacun(accNumber);
			if (temp != null)
			{
				if (temp.getPassword() == password)
				{
					return true;
				}
			}
			return false;
		}
	}
}
