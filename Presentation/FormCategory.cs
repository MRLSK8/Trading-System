using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trade;

namespace Presentation
{
	public partial class FormCategory : Form
	{
		private bool isNew = false;
		private bool isEdit = false;

		public FormCategory()
		{
			InitializeComponent();
			this.toolTipMessage.SetToolTip(this.textNameCat, "Enter the category name");
			this.toolTipMessage.SetToolTip(this.textIdCat, "Enter the category code");
			this.toolTipMessage.SetToolTip(this.textDescriptionCat, "Enter the category description");
		}

		private void ShowMessageOk(string message)
		{
			MessageBox.Show(message, "Trading System", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void ShowMessageError(string message)
		{
			MessageBox.Show(message, "Trading System", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void ClearFields()
		{
			this.textIdCat.Text = String.Empty;
			this.textNameCat.Text = String.Empty;
			this.textDescriptionCat.Text = String.Empty;
		}

		private void EnableFields(bool value)
		{
			this.textIdCat.ReadOnly = !value;
			this.textNameCat.ReadOnly = !value;
			this.textDescriptionCat.ReadOnly = !value;
		}

		private void EnableButtons()
		{
			if(this.isNew || this.isEdit)
			{
				this.EnableFields(true);
				this.btnNew.Enabled = false;
				this.btnSave.Enabled = true;
				this.btnEdit.Enabled = false;
				this.btnCancel.Enabled = true;
			}
			else
			{
				this.EnableFields(false);
				this.btnNew.Enabled = true;
				this.btnSave.Enabled = false;
				this.btnEdit.Enabled = true;
				this.btnCancel.Enabled = false;
			}
		}

		// Hide columns from DataGridView
		private void HideColumns()
		{
			this.dataList.Columns[0].Visible = false;
			this.dataList.Columns[1].Visible = false;
		}

		private void ShowOnDataGrid()
		{
			this.dataList.DataSource = TradeCategory.Show();
			this.HideColumns();
			lblTotal.Text = "Total categories: " + Convert.ToString(dataList.Rows.Count);
		}

		private void FindByName()
		{
			this.dataList.DataSource = TradeCategory.FindName(this.textFindName.Text);
			this.HideColumns();
			lblTotal.Text = "Total categories: " + Convert.ToString(dataList.Rows.Count);
		}

		private void FormCategory_Load(object sender, EventArgs e)
		{
			this.Top = 0;
			this.Left = 0;
			this.ShowOnDataGrid();
			this.EnableButtons();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{

		}

		private void button4_Click(object sender, EventArgs e)
		{

		}
	}
}
