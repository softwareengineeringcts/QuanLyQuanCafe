using Coffee.DAO;
using Coffee.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
		}

		void LoadTable()
		{
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
						btn.BackColor = Color.LightYellow;
						break;
				}

				flpTable.Controls.Add(btn);
			}
		}
		void ShowBill(int id)
		{
			lsvBill.Items.Clear();
			List<Coffee.DTO.Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);

			foreach (Coffee.DTO.Menu item in listBillInfo)
			{
				ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
				lsvItem.SubItems.Add(item.Count.ToString());
				lsvItem.SubItems.Add(item.Price.ToString());
				lsvItem.SubItems.Add(item.TotalPrice.ToString());

				lsvBill.Items.Add(lsvItem);
			}
		}
		void btn_Click(Object sender, EventArgs e)
		{
			int tableID = ((sender as Button).Tag as Table).ID;
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
	}
}
