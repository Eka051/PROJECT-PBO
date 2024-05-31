using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COFFE_SHARP.Models
{
    public class LoginAdmin
    {
        private string username;
        private string hashedPassword;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return hashedPassword; }
            set { hashedPassword = value; }
        }

        public LoginAdmin(string username, string hashedPassword)
        {
            this.username = username;
            this.hashedPassword = hashedPassword;
        }
    }
}
