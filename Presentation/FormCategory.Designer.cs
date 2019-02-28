namespace Presentation
{
	partial class FormCategory
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.chboxDelete = new System.Windows.Forms.CheckBox();
			this.dataList = new System.Windows.Forms.DataGridView();
			this.Delete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.lblTotal = new System.Windows.Forms.Label();
			this.btnPrint = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnFindName = new System.Windows.Forms.Button();
			this.textFindName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnNew = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.textDescriptionCat = new System.Windows.Forms.TextBox();
			this.textNameCat = new System.Windows.Forms.TextBox();
			this.textIdCat = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.errorIcon = new System.Windows.Forms.ErrorProvider(this.components);
			this.toolTipMessage = new System.Windows.Forms.ToolTip(this.components);
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataList)).BeginInit();
			this.tabPage2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorIcon)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Navy;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(131, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "Categories";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabControl1.Location = new System.Drawing.Point(5, 52);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(742, 419);
			this.tabControl1.TabIndex = 1;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.chboxDelete);
			this.tabPage1.Controls.Add(this.dataList);
			this.tabPage1.Controls.Add(this.lblTotal);
			this.tabPage1.Controls.Add(this.btnPrint);
			this.tabPage1.Controls.Add(this.btnDelete);
			this.tabPage1.Controls.Add(this.btnFindName);
			this.tabPage1.Controls.Add(this.textFindName);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Location = new System.Drawing.Point(4, 34);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(734, 381);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "List of categories";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// chboxDelete
			// 
			this.chboxDelete.AutoSize = true;
			this.chboxDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chboxDelete.Location = new System.Drawing.Point(8, 60);
			this.chboxDelete.Name = "chboxDelete";
			this.chboxDelete.Size = new System.Drawing.Size(75, 24);
			this.chboxDelete.TabIndex = 7;
			this.chboxDelete.Text = "Delete";
			this.chboxDelete.UseVisualStyleBackColor = true;
			// 
			// dataList
			// 
			this.dataList.AllowUserToAddRows = false;
			this.dataList.AllowUserToDeleteRows = false;
			this.dataList.AllowUserToOrderColumns = true;
			this.dataList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete});
			this.dataList.Location = new System.Drawing.Point(8, 90);
			this.dataList.MultiSelect = false;
			this.dataList.Name = "dataList";
			this.dataList.ReadOnly = true;
			this.dataList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataList.Size = new System.Drawing.Size(720, 285);
			this.dataList.TabIndex = 6;
			// 
			// Delete
			// 
			this.Delete.HeaderText = "Delete";
			this.Delete.Name = "Delete";
			this.Delete.ReadOnly = true;
			// 
			// lblTotal
			// 
			this.lblTotal.AutoSize = true;
			this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotal.Location = new System.Drawing.Point(668, 60);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(60, 24);
			this.lblTotal.TabIndex = 5;
			this.lblTotal.Text = "label3";
			// 
			// btnPrint
			// 
			this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPrint.Location = new System.Drawing.Point(482, 9);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(78, 29);
			this.btnPrint.TabIndex = 4;
			this.btnPrint.Text = "Print";
			this.btnPrint.UseVisualStyleBackColor = true;
			// 
			// btnDelete
			// 
			this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.Location = new System.Drawing.Point(389, 9);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(78, 29);
			this.btnDelete.TabIndex = 3;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnFindName
			// 
			this.btnFindName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFindName.Location = new System.Drawing.Point(296, 9);
			this.btnFindName.Name = "btnFindName";
			this.btnFindName.Size = new System.Drawing.Size(78, 29);
			this.btnFindName.TabIndex = 2;
			this.btnFindName.Text = "Search";
			this.btnFindName.UseVisualStyleBackColor = true;
			// 
			// textFindName
			// 
			this.textFindName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textFindName.Location = new System.Drawing.Point(77, 9);
			this.textFindName.Name = "textFindName";
			this.textFindName.Size = new System.Drawing.Size(203, 29);
			this.textFindName.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(3, 13);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 25);
			this.label2.TabIndex = 0;
			this.label2.Text = "Name";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.groupBox1);
			this.tabPage2.Location = new System.Drawing.Point(4, 34);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(734, 381);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Settings";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnCancel);
			this.groupBox1.Controls.Add(this.btnNew);
			this.groupBox1.Controls.Add(this.btnEdit);
			this.groupBox1.Controls.Add(this.btnSave);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.textDescriptionCat);
			this.groupBox1.Controls.Add(this.textNameCat);
			this.groupBox1.Controls.Add(this.textIdCat);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Location = new System.Drawing.Point(8, 18);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(691, 352);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Categories";
			// 
			// btnCancel
			// 
			this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancel.Location = new System.Drawing.Point(258, 231);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(68, 30);
			this.btnCancel.TabIndex = 10;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.button4_Click);
			// 
			// btnNew
			// 
			this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNew.Location = new System.Drawing.Point(10, 231);
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(68, 30);
			this.btnNew.TabIndex = 9;
			this.btnNew.Text = "New";
			this.btnNew.UseVisualStyleBackColor = true;
			// 
			// btnEdit
			// 
			this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEdit.Location = new System.Drawing.Point(93, 231);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(68, 30);
			this.btnEdit.TabIndex = 8;
			this.btnEdit.Text = "Edit";
			this.btnEdit.UseVisualStyleBackColor = true;
			// 
			// btnSave
			// 
			this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.Location = new System.Drawing.Point(177, 231);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(68, 30);
			this.btnSave.TabIndex = 7;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(6, 128);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(104, 24);
			this.label5.TabIndex = 6;
			this.label5.Text = "Description";
			// 
			// textDescriptionCat
			// 
			this.textDescriptionCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textDescriptionCat.Location = new System.Drawing.Point(125, 128);
			this.textDescriptionCat.Multiline = true;
			this.textDescriptionCat.Name = "textDescriptionCat";
			this.textDescriptionCat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textDescriptionCat.Size = new System.Drawing.Size(201, 68);
			this.textDescriptionCat.TabIndex = 5;
			// 
			// textNameCat
			// 
			this.textNameCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textNameCat.Location = new System.Drawing.Point(82, 91);
			this.textNameCat.Name = "textNameCat";
			this.textNameCat.Size = new System.Drawing.Size(133, 26);
			this.textNameCat.TabIndex = 4;
			// 
			// textIdCat
			// 
			this.textIdCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textIdCat.Location = new System.Drawing.Point(82, 53);
			this.textIdCat.Name = "textIdCat";
			this.textIdCat.Size = new System.Drawing.Size(133, 26);
			this.textIdCat.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(6, 95);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(61, 24);
			this.label4.TabIndex = 1;
			this.label4.Text = "Name";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(6, 53);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 24);
			this.label3.TabIndex = 0;
			this.label3.Text = "Code";
			// 
			// errorIcon
			// 
			this.errorIcon.ContainerControl = this;
			// 
			// toolTipMessage
			// 
			this.toolTipMessage.IsBalloon = true;
			// 
			// FormCategory
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(751, 473);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(7);
			this.Name = "FormCategory";
			this.Text = "FormCategory";
			this.Load += new System.EventHandler(this.FormCategory_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataList)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorIcon)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Button btnPrint;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnFindName;
		private System.Windows.Forms.TextBox textFindName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.CheckBox chboxDelete;
		private System.Windows.Forms.DataGridView dataList;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Delete;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textDescriptionCat;
		private System.Windows.Forms.TextBox textNameCat;
		private System.Windows.Forms.TextBox textIdCat;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnNew;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.ErrorProvider errorIcon;
		private System.Windows.Forms.ToolTip toolTipMessage;
	}
}