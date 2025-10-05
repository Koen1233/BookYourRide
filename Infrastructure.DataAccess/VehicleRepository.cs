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
            List<VehicleDTO> vehicles = new List<VehicleDTO>();

            return vehicles;
        }
    }
}
