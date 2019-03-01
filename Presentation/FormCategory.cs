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
			this.textIdCat.Enabled = false;
			this.textNameCat.Enabled = value;
			this.textDescriptionCat.Enabled = value;
		}

		private void EnableButtons()
		{
			if(this.IsNew || this.IsEdit)
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

		public bool IsNew {
			get => isNew;
			set => isNew = value;
		}
		public bool IsEdit {
			get => isEdit;
			set => isEdit = value;
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
			lblTotal.Text = "Number of Records: " + Convert.ToString(dataList.Rows.Count);

			dataList.AutoResizeColumns();
		}

		private void FindByName()
		{
			this.dataList.DataSource = TradeCategory.FindName(this.textFindName.Text);
			this.HideColumns();
			lblTotal.Text = "Number of Records: " + Convert.ToString(dataList.Rows.Count);

			dataList.AutoResizeColumns();
		}

		private void FormCategory_Load(object sender, EventArgs e)
		{
			this.ShowOnDataGrid();
			this.EnableButtons();
		}

		private void textFindName_TextChanged(object sender, EventArgs e)
		{
			this.FindByName();
		}

		private void btnNew_Click(object sender, EventArgs e)
		{
			this.IsNew = true;
			this.IsEdit = false;
			this.EnableButtons();
			this.ClearFields();
			this.textNameCat.Focus();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				string response = "";

				if (this.textNameCat.Text == String.Empty)
				{
					this.ShowMessageError("Name field is required!");
					errorIcon.SetError(textNameCat, "Enter a name");
				}
				else
				{
					errorIcon.Clear();
					if (this.IsNew)
					{
						response = TradeCategory.Insert(this.textNameCat.Text.Trim(), this.textDescriptionCat.Text.Trim());
					}
					else
					{
						response = TradeCategory.Update(Convert.ToInt32(this.textIdCat.Text), this.textNameCat.Text.Trim(), this.textDescriptionCat.Text.Trim());
					}

					if (response.Equals("OK"))
					{
						if (this.IsNew)
						{
							this.ShowMessageOk(" Record saved successfully!");
						}
						else
						{
							this.ShowMessageOk(" Record updated successfully!");
						}
					}
					else
					{
						this.ShowMessageError(response);
					}

					this.IsNew = false;
					this.IsEdit = false;
					this.EnableButtons();
					this.ClearFields();
					this.ShowOnDataGrid();
				}
			}
			catch (Exception error)
			{
				MessageBox.Show(" Error saving information! \n\n" + error.Message);
			}
		}

		private void dataList_DoubleClick(object sender, EventArgs e)
		{
			this.textIdCat.Text = Convert.ToString(this.dataList.CurrentRow.Cells["idcategory"].Value);
			this.textNameCat.Text = Convert.ToString(this.dataList.CurrentRow.Cells["name"].Value);
			this.textDescriptionCat.Text = Convert.ToString(this.dataList.CurrentRow.Cells["description"].Value);
			this.tabControl1.SelectedIndex = 1;
			this.IsNew = false;
			this.IsEdit = false;
			this.EnableButtons();
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			if (this.textIdCat.Text.Equals(" ") || this.textIdCat.Text == String.Empty)
			{
				this.ShowMessageError("Select a record to edit!");
			}
			else
			{
				this.isEdit = true;
				this.EnableButtons();
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			errorIcon.Clear();
			this.IsNew = false;
			this.IsEdit = false;
			this.EnableButtons();
			this.ClearFields();
		}

		private void chboxDelete_CheckedChanged(object sender, EventArgs e)
		{
			if (chboxDelete.Checked)
			{
				this.dataList.Columns[0].Visible = true;
			}
			else
			{
				this.dataList.Columns[0].Visible = false;
			}
		}

		private void dataList_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == dataList.Columns["Delete"].Index)
			{
				DataGridViewCheckBoxCell chBoxDelete = (DataGridViewCheckBoxCell)dataList.Rows[e.RowIndex].Cells["Delete"];
				chBoxDelete.Value = !Convert.ToBoolean(chBoxDelete.Value);
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			try
			{
				DialogResult option;
				option = MessageBox.Show("Do you really want to delete these records?", "Trading System", MessageBoxButtons.OKCancel, MessageBoxIcon.Question); ;

				if (option == DialogResult.OK)
				{
					string code;
					string response = "";

					foreach (DataGridViewRow row in dataList.Rows)
					{
						if (Convert.ToBoolean(row.Cells[0].Value))
						{
							code = Convert.ToString(row.Cells[1].Value);
							response = TradeCategory.Delete(Convert.ToInt32(code));

							if(response != "OK")
							{
								this.ShowMessageError(response);
							}
						}
					}
					this.ShowMessageOk("Record deleted successfully");
					this.ShowOnDataGrid();
				}
			}
			catch (Exception error)
			{
				MessageBox.Show("Error: Deletion failed!\n\n" + error.Message);
			}
		}
	}
}
