using Core.Domain.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Core.Domain
{
    public class Employee
    {
        public Login loginCredentials {  get; private set; }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public bool Status { get; private set; }

        private List<Ride> _rides = new();

        public IReadOnlyList<Ride> Rides { get { return _rides; } }

        //Nog niks met employee gedaan
        public Employee(Login loginCreds, string firstName, string lastName, bool status, List<Ride> rides)
        {
            loginCredentials = loginCreds;
            FirstName = firstName;
            LastName = lastName;
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
        //Validatie toepassen, checken juiste authorisatie of de employee wel status mag aanpassen?

        internal static void ChangeEmployeeStatus(Employee employee, bool status)
        {

        }
        internal static void ChangeVehicleStatus(Vehicle vehicle, bool status)
        {

        }
    }
}
