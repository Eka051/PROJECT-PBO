using System;
using Npgsql;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COFFE_SHARP.Models
{
    internal class RegisterContext
    {
        private readonly string connStr;

        public RegisterContext()
        {
            connStr = "Host=localhost;Port=5432;Username=postgres;Password=dianeka@05;Database=CoffeSharp;";
        }
        public bool Daftar(string nama_admin, string username, string hashedPassword)
        {
            int id_admin = GenerateIdAdmin();

            string query_select = "SELECT * FROM admin WHERE username_admin = @username";

            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(query_select, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    object result = cmd.ExecuteScalar();
                    int count = (result != null) ? Convert.ToInt32(result) : 0;
                    if (count > 0)
                    {
                        return false;
                    }
                }
                conn.Close();
            }

            string query_insert = "INSERT INTO admin (id_admin, nama, username_admin, password_admin) VALUES (@id, @nama, @username, @password) ";

            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                conn.Open(); 

                using (NpgsqlCommand cmd = new NpgsqlCommand(query_insert, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id_admin);
                    cmd.Parameters.AddWithValue("@nama", nama_admin);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", hashedPassword);

                    try 
                    {
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return false;
                    }
                }

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(hashedPassword))
                {
                    return false;
                }

                conn.Close();
            }
            return false;
        }

        private int GenerateIdAdmin()
        {
            int id_admin = 0;
            string query = "SELECT MAX(id_admin) FROM admin";

            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    object result = cmd.ExecuteScalar();

                    if (result == DBNull.Value)
                    {
                        id_admin = 1;
                    }
                    else
                    {
                        id_admin = Convert.ToInt32(result) + 1;
                    }
                }
                conn.Close();
            }
            return id_admin;
        }


    }
}
