using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
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
			string response;

			try
			{
				string connection_string = "INSERT INTO `category` VALUES (DEFAULT,'" + this.Name + "', '" + this.Description + "')";
				MySqlCommand commandInsert = new MySqlCommand(connection_string, connector.Connect());
				commandInsert.ExecuteNonQuery();

				response = "OK";
				connector.Disconnect();
			}
			catch (Exception error)
			{
				MessageBox.Show("Error connecting to the database! (Insert Into)\n\n" + error.Message);
				response = "Insertion error";
			}
			
			return response;
		}

		public string Update(DataCategory Category)
		{
			ConnectionDB connector = new ConnectionDB();
			string response;

			try
			{
				string connection_string = "UPDATE `category` SET name = '" + this._name + "', description = '" + this.Description + "' WHERE idcategory = '" + Convert.ToString(this.IdCategory) + "'";
				MySqlCommand commandUpdate = new MySqlCommand(connection_string, connector.Connect());
				commandUpdate.ExecuteNonQuery();

				response = "OK";  
				connector.Disconnect();

			}
			catch (Exception error)
			{
				MessageBox.Show("Error connecting to the database! (Update)\n\n" + error.Message);
				response = "Update error";
			}

			return response;
		}

		public string Delete(DataCategory Category)
		{
			ConnectionDB connector = new ConnectionDB();
			string response;

			try
			{
				string connection_string = "DELETE FROM category WHERE idcategory = '" + Convert.ToString(this.IdCategory) + "'";
				MySqlCommand commandDelete = new MySqlCommand(connection_string, connector.Connect());
				commandDelete.ExecuteNonQuery();
				response = "OK";

				connector.Disconnect();
			}
			catch (Exception error)
			{
				MessageBox.Show("Error connecting to the database! (Delete)\n\n" + error.Message);
				response = "Deletion error";
			}	

			return response;
		}

		public DataTable Show()
		{
			ConnectionDB connector = new ConnectionDB();
			DataTable DtResult = new DataTable("Category");

			try
			{
				string connection_string = "SELECT * FROM category ORDER BY idcategory DESC LIMIT 20";
				MySqlCommand commandShow = new MySqlCommand(connection_string, connector.Connect());

				MySqlDataAdapter dt = new MySqlDataAdapter(commandShow);
				dt.Fill(DtResult);
			}
			catch (Exception error)
			{
				DtResult = null;
				MessageBox.Show("Error connecting to the database! (Show)\n\n" + error.Message);
			}

			return DtResult;
		}

		public DataTable FindName(DataCategory Category)
		{
			ConnectionDB connector = new ConnectionDB();
			DataTable DtResult = new DataTable("Category");

			try
			{
				string connection_string = "SELECT * FROM `category` WHERE name LIKE '" + this.FindCategoryName + "%'";
				MySqlCommand commandShow = new MySqlCommand(connection_string, connector.Connect());

				MySqlDataAdapter dt = new MySqlDataAdapter(commandShow);
			
				dt.Fill(DtResult);
				
			}
			catch (Exception error)
			{
				DtResult = null;
				MessageBox.Show("Error connecting to the database! (findName)\n\n" + error.Message);
			}

			return DtResult;
		}
	}
}
