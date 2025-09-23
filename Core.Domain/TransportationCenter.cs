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



        //constructor to initialize the name and get all data from the database
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



            CargoRepository cargoRepository = new CargoRepository();
            List<CargoDTO> cargoData = cargoRepository.GetCargo();
            foreach (CargoDTO cargoDTO in cargoData)
            {
                if(cargoDTO.People == 0)
                {
                    Cargo cargo = new Cargo(cargoDTO.Length, cargoDTO.Width, cargoDTO.Height, cargoDTO.Weight);
                }
                else
                {
                    Cargo cargo = new Cargo(cargoDTO.People);
                }
            }
            //Cargo is transferred to the creation of vehicles objects to link them together but does not work with the DTO objects
            //So all data will proceed to be generated in the Helper.HardcodeData class

            

            //VehicleData
            VehicleRepository vehicleRepository = new VehicleRepository();
            List<VehicleDTO> vehicleData = vehicleRepository.GetVehicles(cargoData);
            foreach (VehicleDTO vehicleDTO in vehicleData)
            {
                Vehicle vehicle = new Vehicle(vehicleDTO.Mileage, vehicleDTO.WriteOff, vehicleDTO.MaxLoad, vehicleDTO.PassengerSeats, vehicleDTO.Status, 
                vehicleDTO.Cargo);
                _vehicles.Add(vehicle);
            }

            //EmployeeData
            EmployeeRepository employeeRepository = new EmployeeRepository();
            List<EmployeeDTO> employeeData = employeeRepository.GetEmployees();
            foreach (EmployeeDTO employeeDTO in employeeData)
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

            

            //RideData
            RideRepository rideRepository = new RideRepository();
            List<RideDTO> rideData = rideRepository.GetRides(vehicleData);
            foreach (RideDTO rideDTO in rideData)
            {
                Ride ride = new Ride(rideDTO.Price, rideDTO.Beginning, rideDTO.End, rideDTO.Distance, rideDTO.Date);
                _rides.Add(ride);
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
