using Core.Domain;

internal class Program
{
    private static void Main(string[] args)
    {
        TransportationCenter move = new TransportationCenter("Move");

        Console.WriteLine($"\nTransportation Center: {move.Name}\n");
        foreach (Ride ride in move.Rides)
        {
            Console.WriteLine($"Price: {ride.Price}, Beginning: {ride.Beginning}, End: {ride.End}, Distance: {ride.Distance}, Date: {ride.Date}");
        }
        Console.WriteLine("\n");
        foreach (Employee employee in move.Employees)
        {
            Console.WriteLine($"Email: {employee.Email}, FirstName: {employee.FirstName}, LastName: {employee.LastName}");
        }
        Console.WriteLine("\n");
        foreach (Customer customer in move.Customers)
        {
            Console.WriteLine($"Email: {customer.Email}, FirstName: {customer.FirstName}, LastName: {customer.LastName}");
        }
        Console.WriteLine("\n");
        foreach (Vehicle vehicle in move.Vehicles)
        {
            Console.WriteLine($"Mileage: {vehicle.Mileage}, WriteOff: {vehicle.WriteOff}, MaxLoad: {vehicle.MaxLoad}, PassengerSeats: {vehicle.PassengerSeats}");
        }
    }
}