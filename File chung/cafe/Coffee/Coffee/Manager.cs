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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee
{
	public partial class Manager : Form
	{
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.Type); }
        }

		public Manager(Account acc)
		{	
			InitializeComponent();
            this.LoginAccount = acc;
			LoadTable();
			LoadCategory();
			LoadComboboxTable(cbSwitchTable);
		}

        void ChangeAccount(int type)
        {
            adminToolStripMenuItem.Enabled = type == 1;
            thôngTinCáNhânToolStripMenuItem1.Text += " (" + LoginAccount.DisplayName + ")";
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
		public void ShowBill(int id)
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
            txtTable.Text = ((sender as Button).Tag as Table).Name;
			ShowBill(tableID);
		}
		private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void thôngTinCáNhânToolStripMenuItem1_Click(object sender, EventArgs e)
		{
            AccountProfile f = new AccountProfile(LoginAccount);
            f.UpdateAccount += f_UpdateAccount;
            f.ShowDialog();
		}
		void f_UpdateAccount(object sender, AccountEvent e)
		{
			thôngTinCáNhânToolStripMenuItem1.Text = "Thông tin tài khoản (" + e.Acc.DisplayName + ")";
		}

		private void adminToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Admin f = new Admin();
            f.loginAccount = LoginAccount;
			f.ShowDialog();
		}
      

        private void btnSwitchTable_Click(object sender, EventArgs e)
        {
            int id1 = (lsvBill.Tag as Table).ID;
            int id2 = (cbSwitchTable.SelectedItem as Table).ID;
            if (MessageBox.Show(string.Format("Bạn có thật sự muốn chuyển bàn {0} qua bàn {1}", (lsvBill.Tag as Table).Name, (cbSwitchTable.SelectedItem as Table).Name), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                TableDAO.Instance.SwitchTable(id1, id2);
            }
        }
        void LoadCategory()
        {
            flpCategory.Controls.Clear();

            List<Category> categoryList = CategoryDAO.Instance.GetListCategory();

            foreach (Category item in categoryList)
            {
                Button btn = new Button() { Width = CategoryDAO.CategoryWidth, Height = CategoryDAO.CategoryHeight };
                btn.Text = item.Name + Environment.NewLine;
                btn.Click += btn1_Click;
                btn.Tag = item;

                flpCategory.Controls.Add(btn);
            }
        }
        void LoadFood(int id)
        {
            flpFood.Controls.Clear();
            List<Food> FoodList = FoodDAO.Instance.GetFoodByCategoryID(id);

            foreach (Food item in FoodList)
            {
                Button btn1 = new Button() { Width = FoodDAO.FoodWidth, Height = FoodDAO.FoodHeight };
                btn1.Text = item.Name + Environment.NewLine;
                btn1.Click += btn2_Click;
                btn1.Tag = item;


                flpFood.Controls.Add(btn1);
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;
            if (table == null)
            {
                MessageBox.Show("Hãy chọn bàn trước");
                return;
            }

            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
            int foodID = ((sender as Button).Tag as Food).ID;
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
        private void btn1_Click(object sender, EventArgs e)
        {
            int id = ((sender as Button).Tag as Category).ID;
            LoadFood(id);
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;

            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
            int discount = (int)nmDiscount.Value;
            double Received = Convert.ToDouble(txtReceived.Text.Split(',')[0]);
            double totalPrice = Convert.ToDouble(txtTotalPrice.Text.Split(',')[0]);
            double finalTotalPrice = totalPrice - (totalPrice / 100) * discount;
            double Payment = Received - finalTotalPrice;
            if (idBill != -1)
            {
                if (Received < totalPrice)
                {
                    MessageBox.Show("Số tiền nhận phải lớn hơn tổng tiền hóa đơn !!!", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    if (MessageBox.Show(string.Format("Tổng tiền cho hóa đơn này là : {0} \n Số tiền phụ cho khách hàng là : {1} \n Bạn có chắc thanh toán hóa đơn cho bàn {2}? ", finalTotalPrice, Payment, table.Name), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                    {
                        BillDAO.Instance.CheckOut(idBill, discount, (float)finalTotalPrice);
                        ShowBill(table.ID);
                        LoadTable();
                    }
                }
            }
        }
	}
}
