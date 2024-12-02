using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAccountNamespace
{
    public class UserAccount
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Department { get; set; }

       
        public UserAccount(string username, string password, string fullName, string department)
        {
            Username = username;
            Password = password;
            FullName = fullName;
            Department = department;
        }

        public bool ValidateCredentials(string username, string password)
        {
            return Username == username && Password == password;
        }
    }

    public class Cashier : UserAccount
    {
        public Cashier(string username, string password, string fullName, string department)
            : base(username, password, fullName, department)
        {
        }
    }
}
