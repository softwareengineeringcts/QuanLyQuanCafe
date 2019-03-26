namespace cafe
{
    partial class Login
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
			this.btnLogin = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txt1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.txt2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnLogin
			// 
			this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogin.Location = new System.Drawing.Point(272, 178);
			this.btnLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(102, 28);
			this.btnLogin.TabIndex = 3;
			this.btnLogin.Text = "Đăng nhập";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// btnExit
			// 
			this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.Location = new System.Drawing.Point(418, 178);
			this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(98, 28);
			this.btnExit.TabIndex = 4;
			this.btnExit.Text = "Thoát";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.txt1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(64, 23);
			this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(452, 59);
			this.panel1.TabIndex = 1;
			// 
			// txt1
			// 
			this.txt1.Location = new System.Drawing.Point(145, 14);
			this.txt1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txt1.Multiline = true;
			this.txt1.Name = "txt1";
			this.txt1.Size = new System.Drawing.Size(300, 32);
			this.txt1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 14);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(113, 17);
			this.label1.TabIndex = 2;
			this.label1.Text = "Tên đăng nhập :";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.txt2);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Location = new System.Drawing.Point(64, 95);
			this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(451, 52);
			this.panel2.TabIndex = 2;
			// 
			// txt2
			// 
			this.txt2.Location = new System.Drawing.Point(144, 11);
			this.txt2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txt2.Multiline = true;
			this.txt2.Name = "txt2";
			this.txt2.Size = new System.Drawing.Size(300, 32);
			this.txt2.TabIndex = 2;
			this.txt2.UseSystemPasswordChar = true;
			this.txt2.TextChanged += new System.EventHandler(this.txt2_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(8, 11);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(74, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "Mật khẩu :";
			// 
			// Login
			// 
			this.AcceptButton = this.btnLogin;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnExit;
			this.ClientSize = new System.Drawing.Size(580, 241);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnLogin);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.MaximizeBox = false;
			this.Name = "Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txt1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox txt2;
		private System.Windows.Forms.Label label2;
	}
}

