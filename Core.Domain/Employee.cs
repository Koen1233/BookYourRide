using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain
{
    public class Employee
    {
        public string Email { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Password { get; private set; } //of alles private, een wachtwoord niet zomaar ophalen?

        private List<Ride> _rides = new();

        public IReadOnlyList<Ride> Rides { get { return _rides; } }

        public Employee(string email, string firstName, string lastName, string password)
        {
            Email = email;
            FirstName = firstName;
            LastName = lastName;
            Password = password;
        }

        public void ChangeStatus()
        {

        }

        
        

    }
}
