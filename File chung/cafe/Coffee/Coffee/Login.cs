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
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			string userName = txtUserName.Text;
			string passWord = txtPassword.Text;
			if (login(userName, passWord))
			{
                Account loginAccount = AccountDAO.Instance.GetAccountByUserName(userName);
                Manager f = new Manager(loginAccount);
                this.Hide();
                f.ShowDialog();
                this.Show();
			}
			else
			{
				MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
			}
		}

		bool login(string username,string password)
		{
			return AccountDAO.Instance.Login(username, password);
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void Login_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (MessageBox.Show("Bạn có thật sự muốn thoát không?","Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
			{
				e.Cancel = true;
			}
		}
	}
}
