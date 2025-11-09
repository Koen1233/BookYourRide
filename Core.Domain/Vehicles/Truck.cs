using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Vehicles
{
    public class Truck : Vehicle
    {
        public int MaxLoad { get; private set; }//Kilo's

        public Truck(int mileage, int writeOff, bool status, int maxLoad): base(mileage, writeOff, status)
        {
            Type = VehicleType.Truck;
            MaxLoad = maxLoad;
        }

        public override void CalcWriteOff()
        {
            //Nog implementeren
            throw new NotImplementedException();
        }
    }
}
