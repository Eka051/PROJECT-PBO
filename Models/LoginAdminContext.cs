using Npgsql;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace COFFE_SHARP.Models
{
    public class LoginAdminContext
    {
        private readonly string connStr;

        public event EventHandler dataChanged;
        public event EventHandler<int> AdminLoggedIn;

        public LoginAdminContext()
        {
            connStr = "Host=localhost;Port=5432;Username=postgres;Password=dianeka@05;Database=CoffeSharp;";
        }

        protected virtual void OnDataChanged()
        {
            dataChanged?.Invoke(this, EventArgs.Empty);
        }

        public List<LoginAdmin> GetDataAdmin()
        {
            List<LoginAdmin> listAdmin = new List<LoginAdmin>();
            string query_select = "SELECT id_admin, username_admin, password_admin FROM admin ORDER BY id_admin";
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query_select, conn))
                    {
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                LoginAdmin loginAdmin = new LoginAdmin((string)reader["username_admin"], (string)reader["password_admin"]);
                                loginAdmin.Username = (string)reader["username_admin"];
                                loginAdmin.Password = (string)reader["password_admin"];
                                listAdmin.Add(loginAdmin);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan saat mengambil data admin: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
            OnDataChanged();
            return listAdmin;
        }

        public bool Validate(string username, string password)
        {
            string query = "SELECT id_admin, password_admin FROM admin WHERE username_admin = @username";
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string hashedPassword = (string)reader["password_admin"];
                                if (VerifikasiPassword(password, hashedPassword))
                                {
                                    SessionInfo.idAdmin = Convert.ToInt32(reader["id_admin"]);
                                    AdminLoggedIn?.Invoke(this, SessionInfo.idAdmin);
                                    return true;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan saat memvalidasi login: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //finally
                //{
                //    conn.Close();
                //}
            }
            return false;
        }

        private bool VerifikasiPassword(string password, string hashedPassword)
        {
            string hashedInput = HashPassword(password);
            return hashedInput == hashedPassword;
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

    }
}