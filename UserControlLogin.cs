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
        MainForm mainForm;
        public UserControlLogin(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginAdminContext loginAdminContext = new LoginAdminContext();
            LoginAdmin login = loginAdminContext.Validate(usernameBox.Text, passwordBox.Text);

            if (login != null)
            {
                MessageBox.Show("Login berhasil!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.mainForm.ShowDashboard();
                ClearTextBox();
            }
            else if (string.IsNullOrEmpty(usernameBox.Text) || string.IsNullOrEmpty(passwordBox.Text))
            {
                MessageBox.Show("Username & Password tidak boleh kosong!", "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public void ClearTextBox()
        {
            usernameBox.Text = "";
            passwordBox.Text = "";
        }


        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            mainForm.ShowRegister();
        }
    }
}
