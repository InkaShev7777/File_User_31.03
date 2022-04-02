using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_31._03
{
    class Account
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public Account()
        {
            Name = "";
            LastName = "";
            Password = "";
            Login = "";
        }
        public Account(string name,string lastName,string login,string password)
        {
            Name = name;
            LastName = lastName;
            Login = login;
            Password = password;
        }
        public override string ToString()
        {
            return string.Format("Name: {0}\tLastName: {1}\tLogin: {2}\tPassword: {3}", Name, LastName, Login, Password);
        }
    }
}
