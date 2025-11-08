using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DataAccess.DTO.Vehicles
{
    public class TaxiDTO : VehicleDTO
    {
        public int PassengerSeats { get; set; }

        public TaxiDTO() 
        {
            VehicleType = 1;
        }
    }
}
