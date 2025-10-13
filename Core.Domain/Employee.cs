using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Core.Domain
{
    public class Employee
    {
        //public Login loginCredentials {  get; private set; } //op deze manier de Login klasse verwerken en email, password eruit halen?
        public string Email { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Password { get; private set; }
        public bool Status { get; private set; }

        private List<Ride> _rides = new();

        public IReadOnlyList<Ride> Rides { get { return _rides; } }

        public Employee(string email, string firstName, string lastName, string password, bool status, List<Ride> rides)
        {
            Email = email;
            FirstName = firstName;
            LastName = lastName;
            Password = password;
            Status = status;
            foreach (Ride ride in rides)
            {
                _rides.Add(ride);
            }
        }



        public void ChangeStatus()
        {

        }

        //SRP Changestatus splitsten in onderstaande?

        internal static void ChangeEmployeeStatus(Employee employee, bool status)
        {

        }
        internal static void ChangeVehicleStatus(Vehicle vehicle, bool status)
        {

        }
    }
}
