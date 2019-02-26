using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Data;
using System.Windows;
using DBdata;

namespace DBdata
{
	public class DataCategory
	{
		private int _idCategory;
		private string _name;
		private string _description;
		private string _findCategoryName;

		public DataCategory()
		{

		}

		public DataCategory(int idCategory, string name, string description, string findCategoryName)
		{
			this._idCategory = idCategory;
			this._name = name;
			this._description = description;
			this._findCategoryName = findCategoryName;
		}

		public int IdCategory
		{
			get => _idCategory;
			set => _idCategory = value;
		}
		public string Name
		{
			get => _name;
			set => _name = value;
		}
		public string Description
		{
			get => _description;
			set => _description = value;
		}
		public string FindCategoryName
		{
			get => _findCategoryName;
			set => _findCategoryName = value;
		}

		public string Insert(DataCategory Category)
		{

			ConnectionDB connector = new ConnectionDB();

			string connection_string = "INSERT INTO `category` VALUES (DEFAULT," + this._name + ", " + this._description + ")";
			MySqlCommand commandInsert = new MySqlCommand(connection_string, connector.Connect());

			string response = commandInsert.ExecuteNonQuery() == 1 ? "Insertion completed" : "Insertion error";

			connector.Disconnect();

			return response;
		}

		public string Update(DataCategory Category)
		{
			ConnectionDB connector = new ConnectionDB();

			string connection_string = "UPDATE `category` SET name = " + this._name + ", description = " + this._description + " where idcategory = " + this._idCategory + "";
			MySqlCommand commandUpdate = new MySqlCommand(connection_string, connector.Connect());

			string response = commandUpdate.ExecuteNonQuery() == 1 ? "Update completed" : "Update error";

			connector.Disconnect();

			return response;
		}

		public string Delete(DataCategory Category)
		{
			ConnectionDB connector = new ConnectionDB();

			string connection_string = "DELETE FROM category where idcategory = " + this._idCategory + "";
			MySqlCommand commandDelete = new MySqlCommand(connection_string, connector.Connect());

			string response = commandDelete.ExecuteNonQuery() == 1 ? "Deletion completed" : "Deletion error";

			connector.Disconnect();

			return response;

		}

		public DataTable Show()
		{
			DataTable DtResult = new DataTable("Category");
			ConnectionDB connector = new ConnectionDB();

			try
			{
				SqlConnection connection = new SqlConnection(connector.Stringconnection());
				connection.Open();

				string connection_string = "SELECT * FROM category order by idcategory desc limit = 10";
				SqlCommand commandShow = new SqlCommand(connection_string, connection);

				SqlDataAdapter dt = new SqlDataAdapter(commandShow);
				dt.Fill(DtResult);

			}
			catch (Exception error)
			{
				DtResult = null;
				MessageBox.Show("Error connecting to the database! (sqlconnection)\n\n" + error.Message);
			}

			return DtResult;
		}

		public DataTable FindName(DataCategory Category)
		{
			DataTable DtResult = new DataTable("Category");
			ConnectionDB connector = new ConnectionDB();

			try
			{
				SqlConnection connection = new SqlConnection(connector.Stringconnection());
				connection.Open();

				string connection_string = "SELECT * FROM category where name like " + this._findCategoryName + "%" + " ";
				SqlCommand commandShow = new SqlCommand(connection_string, connection);

				SqlDataAdapter dt = new SqlDataAdapter(commandShow);
				dt.Fill(DtResult);

			}
			catch (Exception error)
			{
				DtResult = null;
				MessageBox.Show("Error connecting to the database! (sqlconnection)\n\n" + error.Message);
			}

			return DtResult;
		}
	}
}
