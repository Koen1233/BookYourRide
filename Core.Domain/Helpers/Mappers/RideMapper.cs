using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.Vehicles;
using Core.Domain.Vehicles.Cargo;
using Infrastructure.DataAccess.DTO;
using Infrastructure.DataAccess.DTO.Cargo;
using Infrastructure.DataAccess.DTO.Vehicles;

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
                Vehicle vehicle;
                Cargo cargo;

                if (rideDTO.VehicleDTO is TruckDTO && rideDTO.CargoDTO is FreightCargoDTO)
                {
                    TruckDTO truckDTO = (TruckDTO)rideDTO.VehicleDTO;
                    vehicle = new Truck(truckDTO.Mileage, truckDTO.WriteOff, truckDTO.Status, truckDTO.MaxLoad);

                    FreightCargoDTO freightCargoDTO = (FreightCargoDTO)rideDTO.CargoDTO; //Type casting voor objecten?
                    cargo = new FreightTransport(freightCargoDTO.Length, freightCargoDTO.Width, freightCargoDTO.Height, freightCargoDTO.Weight);
                }
                else
                {
                    TaxiDTO taxiDTO = (TaxiDTO)rideDTO.VehicleDTO;
                    vehicle = new Taxi(taxiDTO.Mileage, taxiDTO.WriteOff, taxiDTO.Status, taxiDTO.PassengerSeats);

                    PersonCargoDTO personCargoDTO = (PersonCargoDTO)rideDTO.CargoDTO;
                    cargo = new PersonTransport(personCargoDTO.People);
                }

                Ride ride = new Ride(rideDTO.Price, rideDTO.Beginning, rideDTO.End, rideDTO.Distance, rideDTO.Date, vehicle, cargo);

                rides.Add(ride);
            }
            return rides;
        }
    }
}
