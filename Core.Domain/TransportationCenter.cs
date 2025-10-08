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

        //For testing the form without loading data
        public TransportationCenter()
        {
            Name = "test";
        }

        //constructor to initialize the Transportation center and get all data from the database
        public TransportationCenter(string name)
        {
            Name = name;

            //EmployeeRepository employeeRepository = new EmployeeRepository();
            //List<EmployeeDTO> employeeData = employeeRepository.GetEmployees();
            //foreach (EmployeeDTO employeeDTO in employeeData)
            //{
            //    List<Ride> rides = new List<Ride>(); //tijdelijk opslaan rides en meegeven in constructor van employee

            //    for (int i = 0; i < employeeDTO.Rides.Count; i++)
            //    {
            //        Cargo cargo = new Cargo(employeeDTO.Rides[i].CargoDTO.Length, employeeDTO.Rides[i].CargoDTO.Width, employeeDTO.Rides[i].CargoDTO.Height, employeeDTO.Rides[i].CargoDTO.Weight);
            //        Vehicle vehicle = new Vehicle(employeeDTO.Rides[i].VehicleDTO.Mileage, employeeDTO.Rides[i].VehicleDTO.WriteOff, employeeDTO.Rides[i].VehicleDTO.MaxLoad, employeeDTO.Rides[i].VehicleDTO.PassengerSeats, employeeDTO.Rides[i].VehicleDTO.Status, VehicleType.Taxi); //rideDTO.VehicleDTO.VehicleType)
            //        Ride ride = new Ride(employeeDTO.Rides[i].Price, employeeDTO.Rides[i].Beginning, employeeDTO.Rides[i].End, employeeDTO.Rides[i].Distance, employeeDTO.Rides[i].Date, vehicle, cargo);
            //        rides.Add(ride);
            //    }
            //    Employee employee = new Employee(employeeDTO.Email, employeeDTO.FirstName, employeeDTO.LastName, employeeDTO.Password, employeeDTO.Status, rides);
            //    _employees.Add(employee);
            //}
        }

        //Operations
        public bool TryRegistrate(string email, string firstName, string lastName, string password)
        {
            //Check for existing email
            for (int i = 0; i < _customers.Count; i++)
            {
                if (this._customers[i].Email == email)
                {
                    return false;
                }
            }
            //Create a new customer
            Customer customer = new Customer(email, firstName, lastName, password);
            _customers.Add(customer);
            return true;
        }

        public void AddRide(Ride ride)
        {

        }
    }
}
