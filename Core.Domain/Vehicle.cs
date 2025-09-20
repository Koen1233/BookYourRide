using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain
{
    public class Vehicle
    {
        public int Mileage { get; private set; }
        public int WriteOff {  get; private set; }
        public int MaxLoad { get; private set; }
        public int PassengerSeats {  get; private set; }
        public bool Status {  get; private set; }

    }
}
