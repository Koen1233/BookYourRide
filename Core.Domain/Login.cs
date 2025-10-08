using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain
{
    public class Login
    {
        //SRP

        public string Email { get; private set; }
        public string Password { get; private set; }
        public bool IsEmployee { get; private set; }//false = customer, true = employee

        public Login(string email, string password, bool isEmployee)
        {
            Email = email;
            Password = password;
            IsEmployee = isEmployee;
        }
    }
}
