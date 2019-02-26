using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using DBdata;

namespace Trade
{
	public class TradeCategory
	{
		public static string Insert(string name, string description) {
			DataCategory obj = new DataCategory();
			obj.Name = name;
			obj.Description = description;
			
			return obj.Insert(obj);
		}

		public static string Update(int idcategory, string name, string description)
		{
			DataCategory obj = new DataCategory();
			obj.IdCategory = idcategory;
			obj.Name = name;
			obj.Description = description;

			return obj.Update(obj);
		}

		public static string Delete(int idcategory)
		{
			DataCategory obj = new DataCategory();
			obj.IdCategory = idcategory;

			return obj.Delete(obj);
		}

		public static DataTable Show()
		{
			return new DataCategory().Show();
		}

		public static DataTable FindName(string findCategoryName)
		{
			DataCategory obj = new DataCategory();
			obj.FindCategoryName = findCategoryName;

			return obj.FindName(obj);
		}

	}
}
