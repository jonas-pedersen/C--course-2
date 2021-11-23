using System;
using System.Collections.Generic;
using System.Text;

namespace F10_2
{
    abstract class User
    {
        public string Username;
        protected string Password;

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public abstract string Privilege();

        // Ge User en metod ChangePassword(string oldpw, string newpw) som 
        // byter ut lösenordet mot newpw om det gamla lösenordet är lika med oldpw.
        public void ChangePassword(string oldpw, string newpw)
        {
            if (oldpw == Password)
            {
                Password = newpw;
            }
        }

        public override string ToString()
        {
            return $"User: {Username}, Password: {Password}";
        }
    }

    class NormalUser: User
    {
        public NormalUser(string username, string password): base(username, password)
        {

        }

        public override string Privilege()
        {
            return "Normal";
        }
    }

    class AdminUser: User
    {
        public AdminUser(string username, string password) : base(username, password)
        {

        }

        public override string Privilege()
        {
            return "Admin";
        }

        public override string ToString()
        {
            return $"User: {Username} and I am an admin so I won't tell you my password";
        }
    }
}
