using Coffee.DAO;
using Coffee.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee
{
	public partial class Manager : Form
	{
		public Manager()
		{
			InitializeComponent();
			LoadTable();
			LoadCategory();
			LoadComboboxTable(cbSwitchTable);
		}
		void LoadCategory()
		{
			List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
			cbCategory.DataSource = listCategory;
			cbCategory.DisplayMember = "Name";
		}

		void LoadFoodListByCategoryID(int id)
		{
			List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(id);
			cbFood.DataSource = listFood;
			cbFood.DisplayMember = "Name";
		}
		void LoadTable()
		{
			flpTable.Controls.Clear();

			List<Table> tableList = TableDAO.Instance.LoadTableList();

			foreach (Table item in tableList)
			{
				Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
				btn.Text = item.Name + Environment.NewLine + item.Status;
				btn.Click += btn_Click;
				btn.Tag = item;
				switch (item.Status)
				{
					case "Trống":
						btn.BackColor = Color.LightGray;
						break;
					default:
						btn.BackColor = Color.LightSeaGreen;
						break;
				}

				flpTable.Controls.Add(btn);
			}
		}
		void ShowBill(int id)
		{
			lsvBill.Items.Clear();
			List<Coffee.DTO.Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);
			float totalPrice = 0;
			foreach (Coffee.DTO.Menu item in listBillInfo)
			{
				ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
				lsvItem.SubItems.Add(item.Count.ToString());
				lsvItem.SubItems.Add(item.Price.ToString());
				lsvItem.SubItems.Add(item.TotalPrice.ToString());
				totalPrice += item.TotalPrice;
				lsvBill.Items.Add(lsvItem);
			}
			
			txtTotalPrice.Text = totalPrice.ToString();
		}

		void LoadComboboxTable(ComboBox cb)
		{
			cb.DataSource = TableDAO.Instance.LoadTableList();
			cb.DisplayMember = "Name";
		}

		void btn_Click(Object sender, EventArgs e)
		{
			int tableID = ((sender as Button).Tag as Table).ID;
			lsvBill.Tag = (sender as Button).Tag;
			ShowBill(tableID);
		}
		private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void thôngTinCáNhânToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			AccountProfile f = new AccountProfile();
			f.ShowDialog();
		}

		private void adminToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Admin f = new Admin();
			f.ShowDialog();
		}

		private void Manager_Load(object sender, EventArgs e)
		{

		}

		private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
		{
			int id = 0;

			ComboBox cb = sender as ComboBox;

			if (cb.SelectedItem == null)
				return;

			Category selected = cb.SelectedItem as Category;
			id = selected.ID;

			LoadFoodListByCategoryID(id);
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			Table table = lsvBill.Tag as Table;

			int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
			int foodID = (cbFood.SelectedItem as Food).ID;
			int count = (int)nmFoodCount.Value;

			if (idBill == -1)
			{
				BillDAO.Instance.InsertBill(table.ID);
				BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), foodID, count);
			}
			else
			{
				BillInfoDAO.Instance.InsertBillInfo(idBill, foodID, count);
			}

			ShowBill(table.ID);
			LoadTable();
		}

		private void flpTable_Paint(object sender, PaintEventArgs e)
		{

		}

		private void btnCheckout_Click(object sender, EventArgs e)
		{
			Table table = lsvBill.Tag as Table;

			int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
			int discount = (int)nmDiscount.Value;

			double totalPrice = Convert.ToDouble(txtTotalPrice.Text.Split(',')[0]);
			double finalTotalPrice = totalPrice - (totalPrice / 100) * discount;

			if (idBill != -1)
			{
				if (MessageBox.Show(string.Format("Tổng tiền cho hóa đơn này là : {0} \n Bạn có chắc thanh toán hóa đơn cho bàn {1}? ",finalTotalPrice,table.Name), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
				{
					BillDAO.Instance.CheckOut(idBill, discount,(float) finalTotalPrice);
					ShowBill(table.ID);

					LoadTable();
				}
			}
		}

		private void btnSwitchTable_Click(object sender, EventArgs e)
		{
			int id1 = (lsvBill.Tag as Table).ID;
			int id2 = (cbSwitchTable.SelectedItem as Table).ID;
			if (MessageBox.Show(string.Format("Bạn có thật sự muốn chuyển bàn {0} qua bàn {1}", (lsvBill.Tag as Table).Name, (cbSwitchTable.SelectedItem as Table).Name), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
			{
				TableDAO.Instance.SwitchTable(id1, id2);

				LoadTable();
			}
		}
	}
}
