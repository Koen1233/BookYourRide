using Core.Domain.Helper;
using Infrastructure.DataAccess;
using Infrastructure.DataAccess.DTO;

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

        //For testing the form without loading data
        public TransportationCenter()
        {
            Name = "test";
        }

        //constructor to initialize the name and get all data from the HardCodeData helper class
        public TransportationCenter(string name)
        {
            Name = name;

            //For hardcode data generation
            HardCodeData generateData = new HardCodeData();
            
            //Vehicle data
            List<Vehicle> vehicles = generateData.GetVehicleData();
            foreach (Vehicle vehicle in vehicles)
            {
                _vehicles.Add(vehicle);
            }

            //Ride Data
            List<Ride> rides = generateData.GetRideData(vehicles);
            foreach (Ride ride in rides)
            {
                _rides.Add(ride);
            }

            //Customer creation
            List<Customer> customers = generateData.GetCustomeData(rides);
            foreach (Customer customer in customers)
            {
                _customers.Add(customer);
            }

            //Employee Data
            List<Employee> employees = generateData.GetEmployeeData(rides);
            foreach (Employee employee in employees)
            {
                _employees.Add(employee);
            }
        }



        //Operations
        public bool TryLogin(Employee employee, Customer customer)
        {
            //to have a return path
            return false;
        }

        public void TryRegistrate(string email, string firstName, string lastName, string password)
        {
            //Create a new customer
            Customer customer = new Customer(email, firstName, lastName, password);
            _customers.Add(customer);
        }

    }
}
