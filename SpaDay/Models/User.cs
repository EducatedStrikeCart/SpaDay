using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaDay.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public DateTime TimeCreated { get; set; }

        public User() { }

        public User(string username, string email, string password, DateTime temp)
        {
            Username = username;
            Email = email;
            Password = password;
            TimeCreated = temp;
        }

        public User(string username, string email, string password):this(username, email, password, DateTime.Now)
        {

        }


        public Boolean VerifyPassword(string verify)
        {
            return Password == verify;
        }

        public DateTime GetTime()
        {
            return DateTime.Now;
        }
    }
}
