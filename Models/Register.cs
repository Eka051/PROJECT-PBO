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
        private string username { get; set; }
        private string password { get; set; }

        public int Id
        {
            get { return id; }
            set { id = value; }
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

        public Register(string username, string password)
        {
            this.username = username;
            this.password = password;

        }
    }
}
