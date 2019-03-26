namespace cafe
{
	partial class Admin
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
			this.tbAdmin = new System.Windows.Forms.TabControl();
			this.tpBill = new System.Windows.Forms.TabPage();
			this.tpFood = new System.Windows.Forms.TabPage();
			this.tpFoodCategory = new System.Windows.Forms.TabPage();
			this.tpTable = new System.Windows.Forms.TabPage();
			this.tpAccount = new System.Windows.Forms.TabPage();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.dgvBill = new System.Windows.Forms.DataGridView();
			this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
			this.dtpToDate = new System.Windows.Forms.DateTimePicker();
			this.btnViewBill = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnShowFood = new System.Windows.Forms.Button();
			this.btnEditFood = new System.Windows.Forms.Button();
			this.btnDeleteFood = new System.Windows.Forms.Button();
			this.btnAddFood = new System.Windows.Forms.Button();
			this.btnSearchFood = new System.Windows.Forms.Button();
			this.txtSearchFoodName = new System.Windows.Forms.TextBox();
			this.panel7 = new System.Windows.Forms.Panel();
			this.txtFoodID = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel8 = new System.Windows.Forms.Panel();
			this.txtFoodName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panel9 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.cbFoodCategory = new System.Windows.Forms.ComboBox();
			this.panel10 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.nmFoodPrice = new System.Windows.Forms.NumericUpDown();
			this.tbAdmin.SuspendLayout();
			this.tpFood.SuspendLayout();
			this.tpAccount.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel7.SuspendLayout();
			this.panel8.SuspendLayout();
			this.panel9.SuspendLayout();
			this.panel10.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nmFoodPrice)).BeginInit();
			this.SuspendLayout();
			// 
			// tbAdmin
			// 
			this.tbAdmin.Controls.Add(this.tpBill);
			this.tbAdmin.Controls.Add(this.tpFood);
			this.tbAdmin.Controls.Add(this.tpFoodCategory);
			this.tbAdmin.Controls.Add(this.tpTable);
			this.tbAdmin.Controls.Add(this.tpAccount);
			this.tbAdmin.Location = new System.Drawing.Point(11, 8);
			this.tbAdmin.Name = "tbAdmin";
			this.tbAdmin.SelectedIndex = 0;
			this.tbAdmin.Size = new System.Drawing.Size(1087, 559);
			this.tbAdmin.TabIndex = 0;
			// 
			// tpBill
			// 
			this.tpBill.Location = new System.Drawing.Point(4, 22);
			this.tpBill.Name = "tpBill";
			this.tpBill.Padding = new System.Windows.Forms.Padding(3);
			this.tpBill.Size = new System.Drawing.Size(768, 406);
			this.tpBill.TabIndex = 0;
			this.tpBill.Text = "Doanh thu";
			this.tpBill.UseVisualStyleBackColor = true;
			// 
			// tpFood
			// 
			this.tpFood.Controls.Add(this.panel6);
			this.tpFood.Controls.Add(this.panel5);
			this.tpFood.Controls.Add(this.panel4);
			this.tpFood.Controls.Add(this.panel3);
			this.tpFood.Location = new System.Drawing.Point(4, 22);
			this.tpFood.Name = "tpFood";
			this.tpFood.Padding = new System.Windows.Forms.Padding(3);
			this.tpFood.Size = new System.Drawing.Size(1079, 533);
			this.tpFood.TabIndex = 1;
			this.tpFood.Text = "Thức ăn";
			this.tpFood.UseVisualStyleBackColor = true;
			// 
			// tpFoodCategory
			// 
			this.tpFoodCategory.Location = new System.Drawing.Point(4, 22);
			this.tpFoodCategory.Name = "tpFoodCategory";
			this.tpFoodCategory.Padding = new System.Windows.Forms.Padding(3);
			this.tpFoodCategory.Size = new System.Drawing.Size(768, 406);
			this.tpFoodCategory.TabIndex = 2;
			this.tpFoodCategory.Text = "Danh mục";
			this.tpFoodCategory.UseVisualStyleBackColor = true;
			// 
			// tpTable
			// 
			this.tpTable.Location = new System.Drawing.Point(4, 22);
			this.tpTable.Name = "tpTable";
			this.tpTable.Padding = new System.Windows.Forms.Padding(3);
			this.tpTable.Size = new System.Drawing.Size(768, 406);
			this.tpTable.TabIndex = 3;
			this.tpTable.Text = "Bàn ăn";
			this.tpTable.UseVisualStyleBackColor = true;
			// 
			// tpAccount
			// 
			this.tpAccount.Controls.Add(this.panel2);
			this.tpAccount.Controls.Add(this.panel1);
			this.tpAccount.Location = new System.Drawing.Point(4, 22);
			this.tpAccount.Name = "tpAccount";
			this.tpAccount.Padding = new System.Windows.Forms.Padding(3);
			this.tpAccount.Size = new System.Drawing.Size(1079, 533);
			this.tpAccount.TabIndex = 4;
			this.tpAccount.Text = "Tài khoản";
			this.tpAccount.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.dgvBill);
			this.panel1.Location = new System.Drawing.Point(5, 38);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1070, 494);
			this.panel1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btnViewBill);
			this.panel2.Controls.Add(this.dtpToDate);
			this.panel2.Controls.Add(this.dtpFromDate);
			this.panel2.Location = new System.Drawing.Point(5, 4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1070, 33);
			this.panel2.TabIndex = 1;
			// 
			// dgvBill
			// 
			this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBill.Location = new System.Drawing.Point(6, 6);
			this.dgvBill.Name = "dgvBill";
			this.dgvBill.Size = new System.Drawing.Size(1061, 483);
			this.dgvBill.TabIndex = 0;
			// 
			// dtpFromDate
			// 
			this.dtpFromDate.Location = new System.Drawing.Point(8, 8);
			this.dtpFromDate.Name = "dtpFromDate";
			this.dtpFromDate.Size = new System.Drawing.Size(325, 20);
			this.dtpFromDate.TabIndex = 0;
			// 
			// dtpToDate
			// 
			this.dtpToDate.Location = new System.Drawing.Point(730, 8);
			this.dtpToDate.Name = "dtpToDate";
			this.dtpToDate.Size = new System.Drawing.Size(325, 20);
			this.dtpToDate.TabIndex = 0;
			// 
			// btnViewBill
			// 
			this.btnViewBill.Location = new System.Drawing.Point(445, 7);
			this.btnViewBill.Name = "btnViewBill";
			this.btnViewBill.Size = new System.Drawing.Size(167, 21);
			this.btnViewBill.TabIndex = 1;
			this.btnViewBill.Text = "Thống kê";
			this.btnViewBill.UseVisualStyleBackColor = true;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.dataGridView1);
			this.panel3.Location = new System.Drawing.Point(6, 102);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(596, 421);
			this.panel3.TabIndex = 0;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.btnAddFood);
			this.panel4.Controls.Add(this.btnDeleteFood);
			this.panel4.Controls.Add(this.btnEditFood);
			this.panel4.Controls.Add(this.btnShowFood);
			this.panel4.Location = new System.Drawing.Point(6, 6);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(596, 90);
			this.panel4.TabIndex = 1;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.panel10);
			this.panel5.Controls.Add(this.panel9);
			this.panel5.Controls.Add(this.panel8);
			this.panel5.Controls.Add(this.panel7);
			this.panel5.Location = new System.Drawing.Point(608, 102);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(465, 421);
			this.panel5.TabIndex = 2;
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.txtSearchFoodName);
			this.panel6.Controls.Add(this.btnSearchFood);
			this.panel6.Location = new System.Drawing.Point(611, 6);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(462, 90);
			this.panel6.TabIndex = 0;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(5, 5);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(588, 413);
			this.dataGridView1.TabIndex = 0;
			// 
			// btnShowFood
			// 
			this.btnShowFood.Location = new System.Drawing.Point(453, 13);
			this.btnShowFood.Name = "btnShowFood";
			this.btnShowFood.Size = new System.Drawing.Size(110, 62);
			this.btnShowFood.TabIndex = 0;
			this.btnShowFood.Text = "Xem";
			this.btnShowFood.UseVisualStyleBackColor = true;
			// 
			// btnEditFood
			// 
			this.btnEditFood.Location = new System.Drawing.Point(310, 13);
			this.btnEditFood.Name = "btnEditFood";
			this.btnEditFood.Size = new System.Drawing.Size(110, 62);
			this.btnEditFood.TabIndex = 0;
			this.btnEditFood.Text = "Sửa";
			this.btnEditFood.UseVisualStyleBackColor = true;
			// 
			// btnDeleteFood
			// 
			this.btnDeleteFood.Location = new System.Drawing.Point(167, 13);
			this.btnDeleteFood.Name = "btnDeleteFood";
			this.btnDeleteFood.Size = new System.Drawing.Size(110, 62);
			this.btnDeleteFood.TabIndex = 0;
			this.btnDeleteFood.Text = "Xóa";
			this.btnDeleteFood.UseVisualStyleBackColor = true;
			// 
			// btnAddFood
			// 
			this.btnAddFood.Location = new System.Drawing.Point(20, 13);
			this.btnAddFood.Name = "btnAddFood";
			this.btnAddFood.Size = new System.Drawing.Size(110, 62);
			this.btnAddFood.TabIndex = 0;
			this.btnAddFood.Text = "Thêm";
			this.btnAddFood.UseVisualStyleBackColor = true;
			// 
			// btnSearchFood
			// 
			this.btnSearchFood.Location = new System.Drawing.Point(329, 13);
			this.btnSearchFood.Name = "btnSearchFood";
			this.btnSearchFood.Size = new System.Drawing.Size(110, 62);
			this.btnSearchFood.TabIndex = 0;
			this.btnSearchFood.Text = "Tìm";
			this.btnSearchFood.UseVisualStyleBackColor = true;
			// 
			// txtSearchFoodName
			// 
			this.txtSearchFoodName.Location = new System.Drawing.Point(12, 18);
			this.txtSearchFoodName.Multiline = true;
			this.txtSearchFoodName.Name = "txtSearchFoodName";
			this.txtSearchFoodName.Size = new System.Drawing.Size(301, 48);
			this.txtSearchFoodName.TabIndex = 1;
			// 
			// panel7
			// 
			this.panel7.Controls.Add(this.txtFoodID);
			this.panel7.Controls.Add(this.label1);
			this.panel7.Location = new System.Drawing.Point(15, 16);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(427, 64);
			this.panel7.TabIndex = 1;
			// 
			// txtFoodID
			// 
			this.txtFoodID.Location = new System.Drawing.Point(127, 14);
			this.txtFoodID.Multiline = true;
			this.txtFoodID.Name = "txtFoodID";
			this.txtFoodID.ReadOnly = true;
			this.txtFoodID.Size = new System.Drawing.Size(281, 32);
			this.txtFoodID.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(32, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(34, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "ID :";
			// 
			// panel8
			// 
			this.panel8.Controls.Add(this.txtFoodName);
			this.panel8.Controls.Add(this.label2);
			this.panel8.Location = new System.Drawing.Point(15, 97);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(427, 64);
			this.panel8.TabIndex = 2;
			// 
			// txtFoodName
			// 
			this.txtFoodName.Location = new System.Drawing.Point(127, 14);
			this.txtFoodName.Multiline = true;
			this.txtFoodName.Name = "txtFoodName";
			this.txtFoodName.Size = new System.Drawing.Size(281, 32);
			this.txtFoodName.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(32, 22);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(79, 20);
			this.label2.TabIndex = 0;
			this.label2.Text = "Tên món :";
			// 
			// panel9
			// 
			this.panel9.Controls.Add(this.cbFoodCategory);
			this.panel9.Controls.Add(this.label3);
			this.panel9.Location = new System.Drawing.Point(19, 178);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(427, 64);
			this.panel9.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(32, 22);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(90, 20);
			this.label3.TabIndex = 0;
			this.label3.Text = "Danh mục :";
			// 
			// cbFoodCategory
			// 
			this.cbFoodCategory.FormattingEnabled = true;
			this.cbFoodCategory.Location = new System.Drawing.Point(123, 21);
			this.cbFoodCategory.Name = "cbFoodCategory";
			this.cbFoodCategory.Size = new System.Drawing.Size(281, 21);
			this.cbFoodCategory.TabIndex = 1;
			// 
			// panel10
			// 
			this.panel10.Controls.Add(this.nmFoodPrice);
			this.panel10.Controls.Add(this.label4);
			this.panel10.Location = new System.Drawing.Point(19, 265);
			this.panel10.Name = "panel10";
			this.panel10.Size = new System.Drawing.Size(427, 64);
			this.panel10.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(32, 22);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(42, 20);
			this.label4.TabIndex = 0;
			this.label4.Text = "Giá :";
			// 
			// nmFoodPrice
			// 
			this.nmFoodPrice.Location = new System.Drawing.Point(123, 22);
			this.nmFoodPrice.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
			this.nmFoodPrice.Name = "nmFoodPrice";
			this.nmFoodPrice.Size = new System.Drawing.Size(281, 20);
			this.nmFoodPrice.TabIndex = 1;
			// 
			// Admin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1110, 579);
			this.Controls.Add(this.tbAdmin);
			this.MaximizeBox = false;
			this.Name = "Admin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Admin";
			this.tbAdmin.ResumeLayout(false);
			this.tpFood.ResumeLayout(false);
			this.tpAccount.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel7.ResumeLayout(false);
			this.panel7.PerformLayout();
			this.panel8.ResumeLayout(false);
			this.panel8.PerformLayout();
			this.panel9.ResumeLayout(false);
			this.panel9.PerformLayout();
			this.panel10.ResumeLayout(false);
			this.panel10.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nmFoodPrice)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tbAdmin;
		private System.Windows.Forms.TabPage tpBill;
		private System.Windows.Forms.TabPage tpFood;
		private System.Windows.Forms.TabPage tpFoodCategory;
		private System.Windows.Forms.TabPage tpTable;
		private System.Windows.Forms.TabPage tpAccount;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView dgvBill;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.TextBox txtSearchFoodName;
		private System.Windows.Forms.Button btnSearchFood;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Button btnAddFood;
		private System.Windows.Forms.Button btnDeleteFood;
		private System.Windows.Forms.Button btnEditFood;
		private System.Windows.Forms.Button btnShowFood;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnViewBill;
		private System.Windows.Forms.DateTimePicker dtpToDate;
		private System.Windows.Forms.DateTimePicker dtpFromDate;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.TextBox txtFoodName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.TextBox txtFoodID;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel10;
		private System.Windows.Forms.NumericUpDown nmFoodPrice;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel9;
		private System.Windows.Forms.ComboBox cbFoodCategory;
		private System.Windows.Forms.Label label3;
	}
}