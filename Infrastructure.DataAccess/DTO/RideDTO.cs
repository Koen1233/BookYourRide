using Infrastructure.DataAccess.DTO.Cargo;
using Infrastructure.DataAccess.DTO.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DataAccess.DTO
{
    public class RideDTO
    {
        public int Price { get;  set; }
        public string Beginning { get;  set; } = string.Empty;
        public string End { get;  set; } = string.Empty;
        public int Distance { get;  set; }
        public DateTime Date { get;  set; }
        public VehicleDTO VehicleDTO { get; set; } //Nullable ivm foutmelding en lege constructor
        public CargoDTO CargoDTO { get; set; } 

    }
}
