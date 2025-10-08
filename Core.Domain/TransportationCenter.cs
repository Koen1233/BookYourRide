using Core.Domain.Helper;
using Google.Protobuf.WellKnownTypes;
using Infrastructure.DataAccess;
using Infrastructure.DataAccess.DTO;
using System.Runtime.ExceptionServices;

namespace Core.Domain
{
    public class TransportationCenter
    {
        public string Name { get; private set; }

        private List<Employee> _employees = new();
        private List<Customer> _customers = new();
        private List<Ride> _rides = new();
        private List<Vehicle> _vehicles = new();

        public IReadOnlyList<Employee> Employees { get { return _employees; } }
        public IReadOnlyList<Customer> Customers { get { return _customers; } }
        public IReadOnlyList<Ride> Rides { get { return _rides; } }
        public IReadOnlyList<Vehicle> Vehicles { get { return _vehicles; } }
 
        public TransportationCenter(string name)
        {
            Name = name;
        }

        
        //public bool TryRegistrate(string email, string firstName, string lastName, string password)
        //{
        //    //Check for existing email
        //    for (int i = 0; i < _customers.Count; i++)
        //    {
        //        if (this._customers[i].Email == email)
        //        {
        //            return false;
        //        }
        //    }
        //    //Create a new customer
        //    Customer customer = new Customer(email, firstName, lastName, password);
        //    _customers.Add(customer);
        //    return true;
        //}

        public void AddRide(Ride ride)
        {

        } //niet meer hier nodig ivm database
    }
}
