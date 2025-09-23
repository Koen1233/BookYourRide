using Infrastructure.DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DataAccess
{
    public class VehicleRepository
    {
        public List<VehicleDTO> GetVehicles(List<CargoDTO> cargo)
        {
            List<VehicleDTO> vehicles = new List<VehicleDTO>
            {
                new VehicleDTO(cargo[0])
                {
                    Mileage = 15000,
                    WriteOff = 90,
                    MaxLoad = 20000,
                    PassengerSeats = 2,
                    Status = true
                },
                new VehicleDTO(cargo[2])
                {
                    Mileage = 100000,
                    WriteOff = 85,
                    MaxLoad = 20000,
                    PassengerSeats = 2,
                    Status = false
                },
                new VehicleDTO(cargo[1])
                {
                    Mileage = 35000,
                    WriteOff = 99,
                    MaxLoad = 800,
                    PassengerSeats = 4,
                    Status = true
                }
            };
            return vehicles;
        }
    }
}
