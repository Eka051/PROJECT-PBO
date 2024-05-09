using COFFE_SHARP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COFFE_SHARP
{
    public partial class UserControlLogin : UserControl
    {
        MainForm FormParent;
        public UserControlLogin(MainForm FormParent)
        {
            InitializeComponent();
            this.FormParent = FormParent;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginAdminContext loginAdminContext = new LoginAdminContext();
            LoginAdmin login = loginAdminContext.Validate(usernameBox.Text, passwordBox.Text);

            if (login != null)
            {
                MessageBox.Show("Login berhasil!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.FormParent.ShowDashboard();
            }
            else
            {
                MessageBox.Show("Username atau Password salah. Masukkan dengan benar!", "LOGIN FAILED", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
            passwordBox.PasswordChar = '*';
        }
    }
}
