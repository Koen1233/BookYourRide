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
        public Login loginCredentials {  get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        private List<Ride> _rides = new();

        public IReadOnlyList<Ride> Rides { get { return _rides; } }


        public Customer(Login loginCreds, string firstName, string lastName, List<Ride> rides) 
        {
            loginCredentials = loginCreds;
            FirstName = firstName;
            LastName = lastName;
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
