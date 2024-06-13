using COFFE_SHARP.Models;
using System;
using System.Windows.Forms;

namespace COFFE_SHARP
{
    public partial class UserControlLogin : UserControl
    {
        MainForm mainForm;
        LoginAdminContext loginAdminContext;
        IProdukContext produkContext;

        public UserControlLogin(MainForm mainForm, LoginAdminContext loginAdminContext)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.loginAdminContext = loginAdminContext;
            if (loginAdminContext != null)
            {
                loginAdminContext.dataChanged += LoginAdminContext_dataChanged;
            }
        }

        private void LoginAdminContext_dataChanged(object sender, EventArgs e)
        {
            var dataAdmin = loginAdminContext.GetDataAdmin();

        }

        private void LoginAdminContext_LoginSuccess(object sender, int idAdmin)
        {
            SessionInfo.idAdmin = idAdmin;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Text;
            string password = passwordBox.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username dan Password tidak boleh kosong!", "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool valid = loginAdminContext.Validate(username, password);
            if (valid)
            {
                MessageBox.Show("Login Berhasil!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTextBox();
                mainForm.ShowDashboard();
            }
            else
            {
                MessageBox.Show("Username atau Password salah!", "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ClearTextBox()
        {
            usernameBox.Text = "";
            passwordBox.Text = "";
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            mainForm.ShowRegister();
            ClearTextBox();
        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
            passwordBox.PasswordChar = '●';
        }

        private void UserControlLogin_Load(object sender, EventArgs e)
        {
            
        }
    }
}
