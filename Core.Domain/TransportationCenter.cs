namespace Core.Domain
{
    public class TransportationCenter
    {
        private List<Employee> _employees = new();
        private List<Customer> _customers = new();
        private List<Ride> _rides = new();
        private List<Vehicle> _vehicles = new();
        public List<string> tests { get; private set; } = new List<string>();

        public IReadOnlyList<Employee> Employees { get { return _employees; } }
        public IReadOnlyList<Customer> Customers { get { return _customers; } }
        public IReadOnlyList<Ride> Rides { get { return _rides; } }
        public IReadOnlyList<Vehicle> Vehicles { get { return _vehicles; } }
        public string Name { get; private set; }

        //constructor
        public TransportationCenter(string name)
        {
            Name = name;
        }
    }
}
