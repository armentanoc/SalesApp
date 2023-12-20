﻿using System.Text;
using System.Security.Cryptography;

namespace SalesApp.DomainLayer.Model.Users
{
    public abstract class User
    {
        private String? _username;
        private String? _name;
        private String? _email;
        private String? _password;
        private int _phone;

        
        public String? Username { get { return _username; } }
        public String? Name { get { return _name; } }
        public String? Email { get { return _email; } }
        public int Phone { get { return _phone; } }
        protected String? Password { get { return _password; } }


        public User(String username, String name, String email, String password, int phone)
        {
            _username = username;
            _name = name;
            _email = email;
            _phone = phone;
            SetHashPassword(password);
        }
        

        private void SetHashPassword(String input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));

                StringBuilder builder = new StringBuilder();
                foreach (byte b in hashedBytes)
                {
                    builder.Append(b.ToString("x2"));
                }

                String hashPassword = builder.ToString();

                this._password = hashPassword;
            }
        }

        
        public bool VerifyHashPassword(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));

                StringBuilder builder = new StringBuilder();
                foreach(byte b in hashedBytes)
                {
                    builder.Append(b.ToString("x2"));
                }

                return builder.ToString() == this._password;
            }
        }

        public void UpdatePhone(int phone)
        {
            this._phone = phone;
        }

    }
}
