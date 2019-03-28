namespace Coffee
{
	partial class Manager
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.thôngTinCáNhânToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.listView1 = new System.Windows.Forms.ListView();
			this.cbCategory = new System.Windows.Forms.ComboBox();
			this.cbFood = new System.Windows.Forms.ComboBox();
			this.nmFoodCount = new System.Windows.Forms.NumericUpDown();
			this.btnAdd = new System.Windows.Forms.Button();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.btnCheckout = new System.Windows.Forms.Button();
			this.btnSwitchTable = new System.Windows.Forms.Button();
			this.btnDiscount = new System.Windows.Forms.Button();
			this.nmDiscount = new System.Windows.Forms.NumericUpDown();
			this.cbSwitchtable = new System.Windows.Forms.ComboBox();
			this.menuStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinCáNhânToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1484, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// adminToolStripMenuItem
			// 
			this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
			this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
			this.adminToolStripMenuItem.Text = "Admin";
			this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
			// 
			// thôngTinCáNhânToolStripMenuItem
			// 
			this.thôngTinCáNhânToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem1,
            this.đăngXuấtToolStripMenuItem});
			this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
			this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
			this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin tài khoản";
			// 
			// thôngTinCáNhânToolStripMenuItem1
			// 
			this.thôngTinCáNhânToolStripMenuItem1.Name = "thôngTinCáNhânToolStripMenuItem1";
			this.thôngTinCáNhânToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
			this.thôngTinCáNhânToolStripMenuItem1.Text = "Thông tin cá nhân";
			this.thôngTinCáNhânToolStripMenuItem1.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem1_Click);
			// 
			// đăngXuấtToolStripMenuItem
			// 
			this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
			this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
			this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnAdd);
			this.panel1.Controls.Add(this.nmFoodCount);
			this.panel1.Controls.Add(this.cbFood);
			this.panel1.Controls.Add(this.cbCategory);
			this.panel1.Location = new System.Drawing.Point(921, 27);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(551, 100);
			this.panel1.TabIndex = 1;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.listView1);
			this.panel2.Location = new System.Drawing.Point(921, 133);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(551, 584);
			this.panel2.TabIndex = 0;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.cbSwitchtable);
			this.panel3.Controls.Add(this.btnDiscount);
			this.panel3.Controls.Add(this.nmDiscount);
			this.panel3.Controls.Add(this.btnSwitchTable);
			this.panel3.Controls.Add(this.btnCheckout);
			this.panel3.Location = new System.Drawing.Point(921, 723);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(551, 126);
			this.panel3.TabIndex = 0;
			// 
			// listView1
			// 
			this.listView1.Location = new System.Drawing.Point(3, 3);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(545, 578);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			// 
			// cbCategory
			// 
			this.cbCategory.FormattingEnabled = true;
			this.cbCategory.Location = new System.Drawing.Point(14, 12);
			this.cbCategory.Name = "cbCategory";
			this.cbCategory.Size = new System.Drawing.Size(302, 21);
			this.cbCategory.TabIndex = 2;
			// 
			// cbFood
			// 
			this.cbFood.FormattingEnabled = true;
			this.cbFood.Location = new System.Drawing.Point(14, 39);
			this.cbFood.Name = "cbFood";
			this.cbFood.Size = new System.Drawing.Size(302, 21);
			this.cbFood.TabIndex = 2;
			// 
			// nmFoodCount
			// 
			this.nmFoodCount.Location = new System.Drawing.Point(14, 66);
			this.nmFoodCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
			this.nmFoodCount.Name = "nmFoodCount";
			this.nmFoodCount.Size = new System.Drawing.Size(120, 20);
			this.nmFoodCount.TabIndex = 3;
			this.nmFoodCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(367, 16);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(151, 64);
			this.btnAdd.TabIndex = 4;
			this.btnAdd.Text = "Thêm món";
			this.btnAdd.UseVisualStyleBackColor = true;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 27);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(904, 821);
			this.flowLayoutPanel1.TabIndex = 2;
			// 
			// btnCheckout
			// 
			this.btnCheckout.Location = new System.Drawing.Point(415, 10);
			this.btnCheckout.Name = "btnCheckout";
			this.btnCheckout.Size = new System.Drawing.Size(126, 111);
			this.btnCheckout.TabIndex = 0;
			this.btnCheckout.Text = "Thanh toán";
			this.btnCheckout.UseVisualStyleBackColor = true;
			// 
			// btnSwitchTable
			// 
			this.btnSwitchTable.Location = new System.Drawing.Point(33, 10);
			this.btnSwitchTable.Name = "btnSwitchTable";
			this.btnSwitchTable.Size = new System.Drawing.Size(135, 45);
			this.btnSwitchTable.TabIndex = 0;
			this.btnSwitchTable.Text = "Chuyển bàn";
			this.btnSwitchTable.UseVisualStyleBackColor = true;
			// 
			// btnDiscount
			// 
			this.btnDiscount.Location = new System.Drawing.Point(236, 10);
			this.btnDiscount.Name = "btnDiscount";
			this.btnDiscount.Size = new System.Drawing.Size(135, 45);
			this.btnDiscount.TabIndex = 0;
			this.btnDiscount.Text = "Thanh toán";
			this.btnDiscount.UseVisualStyleBackColor = true;
			// 
			// nmDiscount
			// 
			this.nmDiscount.Location = new System.Drawing.Point(236, 79);
			this.nmDiscount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
			this.nmDiscount.Name = "nmDiscount";
			this.nmDiscount.Size = new System.Drawing.Size(135, 20);
			this.nmDiscount.TabIndex = 3;
			this.nmDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// cbSwitchtable
			// 
			this.cbSwitchtable.FormattingEnabled = true;
			this.cbSwitchtable.Location = new System.Drawing.Point(33, 78);
			this.cbSwitchtable.Name = "cbSwitchtable";
			this.cbSwitchtable.Size = new System.Drawing.Size(135, 21);
			this.cbSwitchtable.TabIndex = 4;
			// 
			// Manager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1484, 861);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Manager";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Phần mềm 3T- Coffee";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.NumericUpDown nmFoodCount;
		private System.Windows.Forms.ComboBox cbFood;
		private System.Windows.Forms.ComboBox cbCategory;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.ComboBox cbSwitchtable;
		private System.Windows.Forms.Button btnDiscount;
		private System.Windows.Forms.NumericUpDown nmDiscount;
		private System.Windows.Forms.Button btnSwitchTable;
		private System.Windows.Forms.Button btnCheckout;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
	}
}