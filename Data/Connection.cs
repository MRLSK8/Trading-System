using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace System.Windows
{
	class ConnectionBD
	{
		public void connect()
		{
			try
			{
				MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;UserId=root;database=tradedb");
				connection.Open();
			}
			catch (Exception erro)
			{
				MessageBox.Show(erro.Message);
			}
		}
		
	}
}
