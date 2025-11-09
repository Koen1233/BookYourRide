using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Vehicles
{
    public class Taxi : Vehicle
    {
        public int PassengerSeats { get; private set; }

        public Taxi(int mileage, int writeOff, bool status, int passengerSeats) : base(mileage, writeOff, status)
        {
            Type = VehicleType.Taxi;
            PassengerSeats = passengerSeats;
        }
        public override void CalcWriteOff()
        {
            //Nog implementeren
            throw new NotImplementedException();
        }
    }
}
