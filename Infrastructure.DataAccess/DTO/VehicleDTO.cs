using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DataAccess.DTO
{
    public class VehicleDTO
    {
        public int Mileage { get;  set; }
        public int WriteOff { get;  set; }
        public int MaxLoad { get;  set; }
        public int PassengerSeats { get;  set; }
        public bool Status { get;  set; }


        //Linking Vehicle with Cargo
        public CargoDTO Cargo { get; set; }


        public VehicleDTO(CargoDTO cargo)
        {
            Cargo = cargo;
        }
    }
}
