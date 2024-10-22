using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
    internal class User
    {
        public int Id { get;  }
        private readonly int _id;
        public string Fullname;
        public string Email;
        private readonly string _password;
        public string Password
        { 
            get 
            {
             return _password;
            } 
            set 
            { 
             if (PasswordChecker())
               _password=value;
            } 
        }

        public User(string fullname, string email, string password)
        {
            ++_id;
            Id=_id;
            Fullname = fullname;
            Email = email;
            Password = password;
        }

        public bool PasswordChecker(string password)
        {
            if (Password.Length>=8)
            {
                return true;
            }
        }   return ;

        public void ShowInfo()
        {
            Console.WriteLine($"fullname: {Fullname},email: {Email},password: {Password}");
        }

    }
}
