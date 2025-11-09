using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Vehicles
{
    public abstract class Vehicle
    {
        public int Mileage { get; private set; } //KM
        public int WriteOff {  get; private set; } // int ranging from 0 to 100 (%)
        public bool Status { get; private set; }
        
        public VehicleType Type { get; protected set; }

        public Vehicle(int mileage, int writeOff, bool status)
        {
            Mileage = mileage;
            WriteOff = writeOff;
            Status = status;
           
            //Type casting van int naar enum
            //Type = (VehicleType)int variabele;
            //Type casting van string naar enum
            //Type = Enum.Parse<VehicleType>("string variabele");
        }

        public abstract void CalcWriteOff();
    }
}
