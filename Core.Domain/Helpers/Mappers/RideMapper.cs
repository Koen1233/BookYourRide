using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.Vehicles;
using Infrastructure.DataAccess.DTO;

namespace Core.Domain.Helpers.Mappers
{
    internal static class RideMapper
    {
        internal static List<Ride> Map(this List<RideDTO> rideDTOs)
        {
            //Converting all DTO objects to domain objects
            List<Ride> rides = new List<Ride>();

            foreach (RideDTO rideDTO in rideDTOs)
            {
                CargoDTO cargoDTO = rideDTO.CargoDTO;
                Cargo cargo = new Cargo(cargoDTO.People, cargoDTO.Length, cargoDTO.Width, cargoDTO.Height, cargoDTO.Weight);

                VehicleDTO vehicleDTO = rideDTO.VehicleDTO;
                Vehicle vehicle = new Vehicle(vehicleDTO.Mileage, vehicleDTO.WriteOff, vehicleDTO.MaxLoad, vehicleDTO.PassengerSeats, vehicleDTO.Status, vehicleDTO.VehicleType);
                
                Ride ride = new Ride(rideDTO.Price, rideDTO.Beginning, rideDTO.End, rideDTO.Distance, rideDTO.Date, vehicle, cargo);

                rides.Add(ride);
            }
            return rides;
        }
    }
}
