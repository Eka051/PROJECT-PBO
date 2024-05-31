using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COFFE_SHARP.Models
{
    internal class Register
    {
        private int id { get; set; }
        private string nama_admin { get; set; }
        private string username { get; set; }
        private string password { get; set; }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nama
        {
            get { return nama_admin; }
            set { nama_admin = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public Register(string nama_admin, string username, string password)
        {
            this.nama_admin = nama_admin;
            this.username = username;
            this.password = password;

        }
    }
}
