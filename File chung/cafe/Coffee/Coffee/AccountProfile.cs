
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
	public partial class AccountProfile : Form
	{
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount); }
        }


		public AccountProfile(Account acc)
		{
			InitializeComponent();
            LoginAccount = acc;
		}

		void ChangeAccount(Account acc)
		{
			txtUserName.Text = LoginAccount.UserName;
			txtDisplayName.Text = LoginAccount.DisplayName;
		}

		void UpdateAccountInfo()
		{
			string displayName = txtDisplayName.Text;
			string password = txtPassword.Text;
			string newpass = txtNewPassword.Text;
			string reenterPass = txtReEnterPassword.Text;
			string userName = txtUserName.Text;

			if (!newpass.Equals(reenterPass))
			{
				MessageBox.Show("Vui lòng nhập lại mật khẩu đúng với mật khẩu mới!");
			}
			else
			{
				if (AccountDAO.Instance.UpdateAccount(userName, displayName, password, newpass))
				{
					MessageBox.Show("Cập nhật thành công");
					if (updateAccount != null)
						updateAccount(this, new AccountEvent(AccountDAO.Instance.GetAccountByUserName(userName)));
				}
				else
				{
					MessageBox.Show("Vui lòng điền đúng mật khấu");
				}
			}
		}

		private event EventHandler<AccountEvent> updateAccount;
		public event EventHandler<AccountEvent> UpdateAccount
		{
			add { updateAccount += value; }
			remove { updateAccount -= value; }
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			UpdateAccountInfo();
		}
	}

	public class AccountEvent : EventArgs
	{
        private Account acc;

        internal Account Acc
        {
            get { return acc; }
            set { acc = value; }
        }


		public AccountEvent(Account acc)
		{
			this.Acc = acc;
		}
	}
}
