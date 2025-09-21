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
        public List<VehicleDTO> GetVehicles()
        {
            List<VehicleDTO> vehicles = new List<VehicleDTO>
            {
                new VehicleDTO
                {
                    Mileage = 15000,
                    WriteOff = 0,
                    MaxLoad = 1200,
                    PassengerSeats = 5,
                    Status = true
                },
                new VehicleDTO
                {
                    Mileage = 45000,
                    WriteOff = 1,
                    MaxLoad = 2000,
                    PassengerSeats = 2,
                    Status = false
                },
                new VehicleDTO
                {
                    Mileage = 3000,
                    WriteOff = 0,
                    MaxLoad = 800,
                    PassengerSeats = 4,
                    Status = true
                }
            };
            return vehicles;
        }
    }
}
