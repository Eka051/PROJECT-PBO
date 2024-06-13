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
using System.Security.Cryptography;
using Microsoft.VisualBasic;

namespace COFFE_SHARP
{
    public partial class UserControlRegister : UserControl
    {
        MainForm mainForm;
        public UserControlRegister(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string nama = namaAdmin.Text.Trim();
            string username = usernameBox.Text.Trim();
            string password = passwordBox.Text.Trim();
            string confirmPassword = confirmPass.Text.Trim();
            string kodeRegistrasi = registerKey.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword) || string.IsNullOrEmpty(kodeRegistrasi))
            {
                MessageBox.Show("Username, Password, Konfirmasi Password, dan Kode Registrasi tidak boleh kosong!", "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (password != confirmPassword)
            {
                MessageBox.Show("Masukkan password yang sama!", "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ValidateRegisterKey(kodeRegistrasi))
            {
                MessageBox.Show("Kode Registrasi tidak valid!", "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string hashedPassword = HashPassword(password);

            RegisterContext registerContext = new RegisterContext();
            bool register = registerContext.Daftar(nama, username, hashedPassword);

            if (register)
            {
                MessageBox.Show("Registrasi berhasil!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTextBox();
                mainForm.ShowLogin();
            }
            else
            {
                MessageBox.Show("Registrasi gagal! Username sudah terdaftar!", "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private bool ValidateRegisterKey(string registerKey)
        {
            string hashedRegisterKey = HashRegisterKey(registerKey);
            return hashedRegisterKey == RegisterKey.ValidateRegisterKey;
        }

        private string HashRegisterKey(string registerKey)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(registerKey));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
            passwordBox.PasswordChar = '●';
        }

        private void confirmPass_TextChanged(object sender, EventArgs e)
        {
            confirmPass.PasswordChar = '●';
        }

        private void ClearTextBox()
        {
            usernameBox.Text = "";
            passwordBox.Text = "";
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            mainForm.ShowLogin();
        }
    }
}
