using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace ToDoList
{
	
	public static class AppData 
	{
		internal static MySqlConnection connection;

		public static Banka Bank { get; set; }

		static AppData()
		{
			Bank = new Banka();
			Bank.addRacun(new Racun(1001, 1111, 0, "Marko", "Markovic"));
		}
	}

}
