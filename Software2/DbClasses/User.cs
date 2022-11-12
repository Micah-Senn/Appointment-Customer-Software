using System;
using System.Collections.Generic;
using System.Text;

namespace Software2
{
    public class User
    {
        public int userId { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int active { get; set; }

        public User()
        {
            username = string.Empty;
        }

        public User(string user, string pass)
        {
            username = user;
            password = pass;
            active = 1;
        }
    }
}