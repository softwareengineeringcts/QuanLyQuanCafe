using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafe
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

		private void btnLogin_Click(object sender, EventArgs e)
		{
			Manager m = new Manager();
			this.Hide();
			m.ShowDialog();
			this.Show();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void Login_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình không?","Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
			{
				e.Cancel = true;
			}
		}

		private void txt2_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
