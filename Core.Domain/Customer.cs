using Org.BouncyCastle.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain
{
    public class Customer
    {
        //public Login loginCredentials {  get; private set; } //op deze manier de Login klasse verwerken en email, password eruit halen?
        public string Email { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Password { get; private set; }

        private List<Ride> _rides = new();

        public IReadOnlyList<Ride> Rides { get { return _rides; } }


        public Customer(string email, string firstName, string lastName, string password, List<Ride> rides) 
        {
            Email = email;
            FirstName = firstName;
            LastName = lastName;
            Password = password;
            foreach (Ride ride in rides)
            {
                _rides.Add(ride);
            }
        }

        public void BookRide()
        {
            
        }
    }
}
