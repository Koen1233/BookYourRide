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

        /// <summary>
        /// 1 = Taxi,
        /// 2 = Truck
        /// </summary>
        public int VehicleType { get; set; }
        //eigenlijk als Enum ophalen, maar dat lukt nog niet dus dan maar als INT, en in de domein in een ENUM veranderen.
        //public VehicleTypeDTO VehicleTypeDTO { get; set; }

    }
}
