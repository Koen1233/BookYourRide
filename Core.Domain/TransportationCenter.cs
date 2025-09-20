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

        

        //constructor
        public TransportationCenter(string name)
        {
            Name = name;
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
