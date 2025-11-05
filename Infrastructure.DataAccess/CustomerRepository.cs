using Infrastructure.DataAccess.DTO;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DataAccess
{
    public class CustomerRepository
    {
       
        public static List<RideDTO> GetRides(int customerID)
        {
            List<RideDTO> rideDTOs = new List<RideDTO>();

            try
            {
                MySqlConnection mysqlConnection = new MySqlConnection("server=localhost.;User ID=KoenV; Password=DBhost013!?; database=bookyourride");
                mysqlConnection.Open();

                MySqlCommand mysqlCommand = new MySqlCommand("SELECT * FROM ride INNER JOIN vehicle INNER JOIN cargo " +
                "on ride.VehicleID = vehicle.VehicleID and ride.CargoID = cargo.CargoID WHERE CustomerID=?CustomerID ORDER BY date;", mysqlConnection);
                mysqlCommand.Parameters.Add(new MySqlParameter("CustomerID", customerID));


                MySqlDataReader mysqlDataReader = mysqlCommand.ExecuteReader();

                while (mysqlDataReader.Read())
                {
                    //Cargo transpot
                    CargoDTO cargoDTO;
                    if (mysqlDataReader.GetInt32("people") == 0)
                    {
                        cargoDTO = new CargoDTO()
                        {
                            Length = mysqlDataReader.GetInt32("length"),
                            Width = mysqlDataReader.GetInt32("width"),
                            Height = mysqlDataReader.GetInt32("height"),
                            Weight = mysqlDataReader.GetInt32("weight"),
                        };
                    }
                    else //Person transport
                    {
                        cargoDTO = new CargoDTO()
                        {
                            People = mysqlDataReader.GetInt32("people"),
                        };
                    }

                    //Get vehicle
                    VehicleDTO vehicleDTO = new VehicleDTO()
                    {
                        Mileage = mysqlDataReader.GetInt32("mileage"),
                        WriteOff = mysqlDataReader.GetInt32("writeOff"),
                        MaxLoad = mysqlDataReader.GetInt32("maxLoad"),
                        PassengerSeats = mysqlDataReader.GetInt32("passengerSeats"),
                        Status = mysqlDataReader.GetBoolean("vehicleStatus"),
                        VehicleType = mysqlDataReader.GetInt32("vehicleType"),
                        //kan niet onderstaande doen dus nu als INT ophalen.
                        //VehicleTypeDTO = mysqlDataReader.GetEnumerator("vehicleType")
                    };

                    //Get ride data and add CargoDTO and VehicleDTO
                    RideDTO rideDTO = new RideDTO()
                    {
                        Price = mysqlDataReader.GetInt32("price"),
                        Beginning = mysqlDataReader.GetString("beginning"),
                        End = mysqlDataReader.GetString("end"),
                        Distance = mysqlDataReader.GetInt32("distance"),
                        Date = mysqlDataReader.GetDateTime("date"),
                        CargoDTO = cargoDTO,
                        VehicleDTO = vehicleDTO,
                    };
                    rideDTOs.Add(rideDTO);
                }
                mysqlConnection.Close();
                return rideDTOs;
            }
            catch
            {
                throw new Exception("Something went wrong with retrieving your rides.");
            }
        }
    }
}
