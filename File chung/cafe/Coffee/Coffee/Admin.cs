using Coffee.DAO;
using Coffee.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee
{
	public partial class Admin : Form
	{
        BindingSource foodList = new BindingSource();
        BindingSource categoryList = new BindingSource();
        BindingSource accountList = new BindingSource();
        public Account loginAccount;
		public Admin()
		{
			InitializeComponent();
            Load();
		}
        List<Food> SearchFoodByName(string name)
        {
            List<Food> listFood = FoodDAO.Instance.SearchFoodByName(name);

            return listFood;
        }
        void Load()
        {
            dgFood.DataSource = foodList;
            dgCategory.DataSource = categoryList;
            dgAccount.DataSource = accountList;
            LoadDateTimePickerBill();
            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
            LoadListFood();
            LoadListCategory();
            LoadAccount();
            LoadCategoryIntoCombobox(cbCategory);
            AddFoodBinding();
            AddCategoryBinding();
            AddAccountBinding();
        }
		void LoadDateTimePickerBill()
		{
			DateTime today = DateTime.Now;
			dtpkFromDate.Value = new DateTime(today.Year, today.Month, 1);
			dtpkToDate.Value = dtpkFromDate.Value.AddMonths(1).AddDays(-1);
		}
		void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
		{
			dgBill.DataSource = BillDAO.Instance.GetBillListByDate(checkIn, checkOut);
		}
        void LoadListFood()
        {
            foodList.DataSource = FoodDAO.Instance.GetListFood();
        }
        void AddFoodBinding()
        {
            txtFoodname.DataBindings.Add(new Binding("Text", dgFood.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txtFoodID.DataBindings.Add(new Binding("Text", dgFood.DataSource, "ID", true, DataSourceUpdateMode.Never));
            nmFoodPrice.DataBindings.Add(new Binding("Value", dgFood.DataSource, "Price", true, DataSourceUpdateMode.Never));
            
        }
        void LoadListCategory()
        {
            categoryList.DataSource = CategoryDAO.Instance.GetListCategory();
        }
        void AddCategoryBinding()
        {
            txtCategoryName.DataBindings.Add(new Binding("Text", dgCategory.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txtCategoryID.DataBindings.Add(new Binding("Text", dgCategory.DataSource, "ID", true, DataSourceUpdateMode.Never));
        }
        void AddAccountBinding()
        {
            txtUserName.DataBindings.Add(new Binding("Text", dgAccount.DataSource, "UserName", true, DataSourceUpdateMode.Never));
            txtDisplayAccount.DataBindings.Add(new Binding("Text", dgAccount.DataSource, "DisplayName", true, DataSourceUpdateMode.Never));
            nmType.DataBindings.Add(new Binding("Value", dgAccount.DataSource, "Type", true, DataSourceUpdateMode.Never));
        }

        void LoadAccount()
        {
            accountList.DataSource = AccountDAO.Instance.GetListAccount();
        }
        void AddAccount(string userName, string displayName, int type)
        {
            if (AccountDAO.Instance.InsertAccount(userName, displayName, type))
            {
                MessageBox.Show("Thêm tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại");
            }

            LoadAccount();
        }

        void EditAccount(string userName, string displayName, int type)
        {
            if (AccountDAO.Instance.UpdateAccount(userName, displayName, type))
            {
                MessageBox.Show("Cập nhật tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật tài khoản thất bại");
            }

            LoadAccount();
        }

        void DeleteAccount(string userName)
        {
            if (loginAccount.UserName.Equals(userName))
            {
                MessageBox.Show("Vui lòng đừng xóa chính tài khoản này!");
                return;
            }
            if (AccountDAO.Instance.DeleteAccount(userName))
            {
                MessageBox.Show("Xóa tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Xóa tài khoản thất bại");
            }

            LoadAccount();
        }

        void ResetPass(string userName)
        {
            if (AccountDAO.Instance.ResetPassword(userName))
            {
                MessageBox.Show("Đặt lại mật khẩu thành công");
            }
            else
            {
                MessageBox.Show("Đặt lại mật khẩu thất bại");
            }
        }
        void LoadCategoryIntoCombobox(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.GetListCategory();
            cb.DisplayMember = "Name";
        }
		private void btnViewBill_Click(object sender, EventArgs e)
		{
			LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
		}

        private void btnShowFood_Click(object sender, EventArgs e)
        {
            LoadListFood();
        }

        private void txtFoodID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgFood.SelectedCells.Count > 0)
                {
                    int id = (int)dgFood.SelectedCells[0].OwningRow.Cells["CategoryID"].Value;

                    Category cateogory = CategoryDAO.Instance.GetCategoryByID(id);

                    cbCategory.SelectedItem = cateogory;

                    int index = -1;
                    int i = 0;
                    foreach (Category item in cbCategory.Items)
                    {
                        if (item.ID == cateogory.ID)
                        {
                            index = i;
                            break;
                        }
                        i++;
                    }

                    cbCategory.SelectedIndex = index;
                }
            }
            catch { }
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            string name = txtFoodname.Text;
            int categoryID = (cbCategory.SelectedItem as Category).ID;
            float price = (float)nmFoodPrice.Value;

            if (FoodDAO.Instance.InsertFood(name, categoryID, price))
            {
                MessageBox.Show("Thêm thành công");
                LoadListFood();
                if (insertFood != null)
                    insertFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm món");
            }
        }

        private void btnEditFood_Click(object sender, EventArgs e)
        {
            string name = txtFoodname.Text;
            int categoryID = (cbCategory.SelectedItem as Category).ID;
            float price = (float)nmFoodPrice.Value;
            int id = Convert.ToInt32(txtFoodID.Text);

            if (FoodDAO.Instance.UpdateFood(id, name, categoryID, price))
            {
                MessageBox.Show("Sửa thành công");
                LoadListFood();
                if (updateFood != null)
                    updateFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa món");
            }
        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtFoodID.Text);

            if (FoodDAO.Instance.DeleteFood(id))
            {
                MessageBox.Show("Xóa thành công");
                LoadListFood();
                if (deleteFood != null)
                    deleteFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa món");
            }
        }
        private event EventHandler insertFood;
        public event EventHandler InsertFood
        {
            add { insertFood += value; }
            remove { insertFood -= value; }
        }

        private event EventHandler deleteFood;
        public event EventHandler DeleteFood
        {
            add { deleteFood += value; }
            remove { deleteFood -= value; }
        }

        private event EventHandler updateFood;
        public event EventHandler UpdateFood
        {
            add { updateFood += value; }
            remove { updateFood -= value; }
        }

        private void btnShowCategory_Click(object sender, EventArgs e)
        {
            LoadListCategory();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string name = txtCategoryName.Text;
            int id = Convert.ToInt32(txtCategoryID.Text);
            if (CategoryDAO.Instance.InsertCategory(id,name))
            {
                MessageBox.Show("Thêm thành công");
                LoadListCategory();
                if (insertCategory != null)
                    insertCategory(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm danh mục");
            }
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtCategoryID.Text);

            if (CategoryDAO.Instance.DeleteCategory(id))
            {
                MessageBox.Show("Xóa thành công");
                LoadListCategory();
                if (deleteCategory != null)
                    deleteCategory(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa món");
            }
        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            string name = txtCategoryName.Text;
            int id = Convert.ToInt32(txtCategoryID.Text);
            if (CategoryDAO.Instance.UpdateCategory(id, name))
            {
                MessageBox.Show("Sửa thành công");
                LoadListCategory();
                if (updateCategory != null)
                    updateCategory(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa danh mục");
            }
        }
        private event EventHandler insertCategory;
        public event EventHandler InsertCategory
        {
            add { insertCategory += value; }
            remove { insertCategory -= value; }
        }

        private event EventHandler deleteCategory;
        public event EventHandler DeleteCategory
        {
            add { deleteCategory += value; }
            remove { deleteCategory -= value; }
        }

        private event EventHandler updateCategory;
        public event EventHandler UpdateCategory
        {
            add { updateCategory += value; }
            remove { updateCategory -= value; }
        }

        private void btnSearchFood_Click(object sender, EventArgs e)
        {
            foodList.DataSource = SearchFoodByName(txtSearchFood.Text);
        }

        private void btnShowAccount_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string displayName = txtDisplayAccount.Text;
            int type = (int)nmType.Value;

            AddAccount(userName, displayName, type);
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;

            DeleteAccount(userName);
        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string displayName = txtDisplayAccount.Text;
            int type = (int)nmType.Value;

            EditAccount(userName, displayName, type);
        }

        private void btnResetButton_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;

            ResetPass(userName);
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            txtPageBill.Text = "1";
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            int page = Convert.ToInt32(txtPageBill.Text);

            if (page > 1)
                page--;

            txtPageBill.Text = page.ToString();
        }

        private void txtPageBill_TextChanged(object sender, EventArgs e)
        {
            dgBill.DataSource = BillDAO.Instance.GetBillListByDateAndPage(dtpkFromDate.Value, dtpkToDate.Value, Convert.ToInt32(txtPageBill.Text));
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int page = Convert.ToInt32(txtPageBill.Text);
            int sumRecord = BillDAO.Instance.GetNumBillListByDate(dtpkFromDate.Value, dtpkToDate.Value);

            if (page < sumRecord)
                page++;

            txtPageBill.Text = page.ToString();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            int sumRecord = BillDAO.Instance.GetNumBillListByDate(dtpkFromDate.Value, dtpkToDate.Value);

            int lastPage = sumRecord / 10;

            if (sumRecord % 10 != 0)
                lastPage++;

            txtPageBill.Text = lastPage.ToString();
        }
	}

}
