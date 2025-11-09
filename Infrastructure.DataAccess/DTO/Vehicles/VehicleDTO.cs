using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DataAccess.DTO.Vehicles
{
    public abstract class VehicleDTO
    {
        public int Mileage { get;  set; }
        public int WriteOff { get;  set; }
        public bool Status { get;  set; }

        /// <summary>
        /// 1 = Taxi,
        /// 2 = Truck
        /// </summary>
        protected int VehicleType { get; set; } 
        //Type nog nodig? Wordt gezet in de child klasse
        //eigenlijk als Enum ophalen, maar dat lukt nog niet
        //Nu ophalen als INT, en in de domein laag in een ENUM veranderen.
    }
}
