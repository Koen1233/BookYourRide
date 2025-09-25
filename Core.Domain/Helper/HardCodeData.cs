using Infrastructure.DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Core.Domain.Helper
{
    internal class HardCodeData
    {

        //Generate some hardcoded data for testing purposes

        internal List<Vehicle> GetVehicleData()
        {
            //create cargo
            List<Cargo> cargo = new List<Cargo>
            {
                new Cargo(50, 4, 2, 10000),
                new Cargo(4),
                new Cargo(30, 1, 2, 5000)
            };

            //create vehicles and link them to cargo
            List<Vehicle> vehicles = new List<Vehicle>
            {
                new Vehicle(15000, 90, 20000, 2, true, cargo[0]),
                new Vehicle(100000, 85, 20000, 2, true, cargo[2]),
                new Vehicle(35000, 99, 800, 4, true, cargo[1])
            };
            return vehicles;
        } 

        internal List<Ride> GetRideData(List<Vehicle> vehicles)
        {
            List<Ride> rides = new List<Ride>()
            {
                new Ride(50, "Venlo", "Tilburg", 100, new DateOnly(2025, 09, 21), vehicles[0]),
                new Ride(100, "Amsterdam", "Groningen", 200, new DateOnly(2025, 10, 25), vehicles[1]),
                new Ride(600, "Maastricht", "Friesland", 300, new DateOnly(2025, 12, 09), vehicles[2]),
                //for easy customer testing
                new Ride(50, "Venlo", "Tilburg", 100, new DateOnly(2025, 12, 21), vehicles[0])
            };
            return rides;
        }

        internal List<Customer> GetCustomeData(List<Ride> rides)
        {
            //Niet zo schaalbaar als had gekund maar ben niet van plan de hardcore uit te breiden
            List<Customer> customers = new List<Customer>();

            Customer c1 = new Customer("alice.customer@example.com", "Alice", "Johnson", "alicePass123"); customers.Add(c1);
            Customer c2 = new Customer("bob.customer@example.com", "Bob", "Smith", "bobPass456"); customers.Add(c2);
            Customer c3 = new Customer("carol.customer@example.com", "Carol", "Williams", "carolPass789"); customers.Add(c3);
            //for easy customer testing
            Customer test = new Customer("a", "a", "a", "a"); customers.Add(test);
            
            c1.HardCodeRide(rides[0]);
            c2.HardCodeRide(rides[1]);
            c3.HardCodeRide(rides[2]);

            test.HardCodeRide(rides[3]);

            return customers;
        }

        internal List<Employee> GetEmployeeData(List<Ride> rides)
        {
            List<Employee> employees = new List<Employee>();
 
            Employee e1 = new Employee("Koenverhalle@gmail.com", "Koen", "Verhalle", "Ridetest"); employees.Add(e1);
            Employee e2 = new Employee("JandeMan@gmail.com", "Jan", "Man", "1234"); employees.Add(e2);
            Employee e3 = new Employee("PietvdVelden@gmail.com", "Piet", "van de Velden", "54321"); employees.Add(e3);
            //for easy employee testing
            Employee test = new Employee("b", "b", "b", "b"); employees.Add(test);

            e1.HardCodeRide(rides[0]);
            e2.HardCodeRide(rides[1]);
            e3.HardCodeRide(rides[2]);

            test.HardCodeRide(rides[3]);

            return employees;
        }
    }
}
