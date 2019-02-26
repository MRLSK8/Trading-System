using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DBdata
{
	public class ConnectionDB
	{
		public MySqlConnection connection;


		public string Stringconnection()
		{
			return "server=localhost;port=3306;UserId=root;database=tradedb";
		}

		public MySqlConnection Connect()
		{
			
			try
			{
				MySqlConnection connection = new MySqlConnection(this.Stringconnection());
				connection.Open();
				this.connection = connection;
				MessageBox.Show("Connected to the database!");

			}
			catch (Exception error)
			{
				MessageBox.Show("Error connecting to the database!\n\n" + error.Message);
			}

			return this.connection;
		
		}
		
		public void Disconnect()
		{
			try
			{
				MySqlConnection connection = new MySqlConnection(this.Stringconnection());
				connection.Close();
				MessageBox.Show("Disconnected");
			}
			catch (Exception error)
			{
				MessageBox.Show("Error disconnecting to the database!\n\n" + error.Message);
			}
			
		}

	}
}
