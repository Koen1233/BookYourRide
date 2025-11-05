using Infrastructure.DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.ComponentModel.DataAnnotations;
using Org.BouncyCastle.Crypto;
using System.Data;

namespace Infrastructure.DataAccess
{
    public class EmployeeRepository
    {
        ///Implementeren, onderstaande is oude code waarmee ik alles van een employee ophaal
        ///Makkelijk aan te passen 
        
       
        //public List<EmployeeDTO> GetEmployees()
        //{
        //    List<EmployeeDTO> employees = new List<EmployeeDTO>();

        //    //MySqlConnection mysqlConnection = new MySqlConnection("Data Source=.;Initial Catalog=bookyourride;Persist Security Info=True;User ID=KoenV;Password=DBhost013!?");
        //    MySqlConnection mysqlConnection = new MySqlConnection("server=localhost.;User ID=KoenV; Password=DBhost013!?; database=bookyourride");
        //    mysqlConnection.Open();

        //    //Nieuwe SQL command uitvoeren naar de database
        //    MySqlCommand mysqlCommand = new MySqlCommand(
        //        "Select * " +
        //        "from employee INNER JOIN ride INNER JOIN vehicle INNER jOIN cargo " +
        //        "on employee.EmployeeID = ride.EmployeeID and " +
        //        "ride.VehicleID = vehicle.VehicleID and " +
        //        "ride.CargoID = cargo.CargoID"
        //        , mysqlConnection);
        //    MySqlDataReader mysqlDataReader = mysqlCommand.ExecuteReader();
        //    while (mysqlDataReader.Read())
        //    {
        //        //int employeeID = mysqlDataReader.GetInt32("EmployeeID");
        //        //foreach (int employeeID in mysqlDataReader.GetInt32("EmployeeID") )


        //        //int people = mysqlDataReader.GetInt32("people");
        //        if (mysqlDataReader.GetInt32("people") == 0)
        //        {
        //            CargoDTO cargo = new CargoDTO()
        //            {
        //                Length = mysqlDataReader.GetInt32("length"),
        //                Width = mysqlDataReader.GetInt32("width"),
        //                Height = mysqlDataReader.GetInt32("height"),
        //                Weight = mysqlDataReader.GetInt32("weight")
        //            };
        //            VehicleDTO vehicle = new VehicleDTO()
        //            {
        //                Mileage = mysqlDataReader.GetInt32("mileage"),
        //                WriteOff = mysqlDataReader.GetInt32("writeOff"),
        //                MaxLoad = mysqlDataReader.GetInt32("maxLoad"),
        //                Status = mysqlDataReader.GetBoolean("vehicleStatus"),
        //                //VehicleTypeDTO = mysqlDataReader.GetEnumerator("vehicleType")
        //                //Andere oplossig, namelijk ophalen als int en niet als ENUM??
        //            };

        //            RideDTO ride = new RideDTO(vehicle, cargo)
        //            {
        //                Price = mysqlDataReader.GetInt32("price"),
        //                Beginning = mysqlDataReader.GetString("beginning"),
        //                End = mysqlDataReader.GetString("end"),
        //                Distance = mysqlDataReader.GetInt32("distance"),
        //                Date = mysqlDataReader.GetDateTime("date")
        //            };

        //            EmployeeDTO employee = new EmployeeDTO()
        //            {
        //                Email = mysqlDataReader.GetString("email"),
        //                FirstName = mysqlDataReader.GetString("firstname"),
        //                LastName = mysqlDataReader.GetString("lastname"),
        //                Password = mysqlDataReader.GetString("password"),
        //                Status = mysqlDataReader.GetBoolean("employeeStatus")
        //            };
        //            employee.Rides.Add(ride);
        //            employees.Add(employee);
        //        }
        //        else
        //        {
        //            CargoDTO cargo = new CargoDTO()
        //            {
        //                People = mysqlDataReader.GetInt32("people")
        //            };
        //            VehicleDTO vehicle = new VehicleDTO()
        //            {
        //                Mileage = mysqlDataReader.GetInt32("mileage"),
        //                WriteOff = mysqlDataReader.GetInt32("writeOff"),
        //                MaxLoad = mysqlDataReader.GetInt32("maxLoad"),
        //                PassengerSeats = mysqlDataReader.GetInt32("passengerSeats"),
        //                Status = mysqlDataReader.GetBoolean("vehicleStatus"),
        //                VehicleType = mysqlDataReader.GetInt32("vehicleType"),
        //                //VehicleTypeDTO 
        //            };

        //            RideDTO ride = new RideDTO(vehicle, cargo)
        //            {
        //                Price = mysqlDataReader.GetInt32("price"),
        //                Beginning = mysqlDataReader.GetString("beginning"),
        //                End = mysqlDataReader.GetString("end"),
        //                Distance = mysqlDataReader.GetInt32("distance"),
        //                Date = mysqlDataReader.GetDateTime("date")
        //            };

        //            EmployeeDTO employee = new EmployeeDTO()
        //            {
        //                Email = mysqlDataReader.GetString("email"),
        //                FirstName = mysqlDataReader.GetString("firstname"),
        //                LastName = mysqlDataReader.GetString("lastname"),
        //                Password = mysqlDataReader.GetString("password"),
        //                Status = mysqlDataReader.GetBoolean("employeeStatus"),

        //            };
        //            employee.Rides.Add(ride);
        //            employees.Add(employee);
        //        }
        //    }

        //    mysqlConnection.Close();

        //    return employees;
        //}
    }
}
