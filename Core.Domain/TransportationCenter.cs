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



        //constructor to initialize the name and get all data from the database
        public TransportationCenter(string name)
        {
            Name = name;
            
            //Get all data to the lists
            //RideData
            RideRepository rideRepository = new RideRepository();
            List<RideDTO> rideData = rideRepository.GetRides();
            foreach (RideDTO rideDTO in rideData)
            {
                Ride ride = new Ride(rideDTO.Price, rideDTO.Beginning, rideDTO.End, rideDTO.Distance, rideDTO.Date);
                _rides.Add(ride);
            }

            //EmployeeData
            EmployeeRepository employeeRepository = new EmployeeRepository();
            List<EmployeeDTO> employeeData = employeeRepository.GetEmployees();
            foreach(EmployeeDTO employeeDTO in employeeData)
            {
                Employee employee = new Employee(employeeDTO.Email, employeeDTO.FirstName, employeeDTO.LastName, employeeDTO.Password);
                _employees.Add(employee);
            }

            //CustomerData
            CustomerRepository customerRepository = new CustomerRepository();
            List<CustomerDTO> customerData = customerRepository.GetCustomers();
            foreach (CustomerDTO customerDTO in customerData)
            {
                Customer customer = new Customer(customerDTO.Email, customerDTO.FirstName, customerDTO.LastName, customerDTO.Password);
                _customers.Add(customer);
            }

            //VehicleData
            VehicleRepository vehicleRepository = new VehicleRepository();
            List<VehicleDTO> vehicleData = vehicleRepository.GetVehicles();
            foreach (VehicleDTO vehicleDTO in vehicleData)
            {
                Vehicle vehicle = new Vehicle(vehicleDTO.Mileage, vehicleDTO.WriteOff, vehicleDTO.MaxLoad, vehicleDTO.PassengerSeats, vehicleDTO.Status);
                _vehicles.Add(vehicle);
            }
        }

        //Operations
        public bool TryLogin(Employee employee, Customer customer)
        {
            //to have a return path
            return false;
        }

        public void Registration(string email, string firstName, string lastName, string password)
        {
            //Create a new customer
            Customer customer = new Customer(email, firstName, lastName, password);
            _customers.Add(customer);
        }

    }
}
