using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain
{
    public class Ride
    {
        public int Price { get; private set; }
        public string Beginning { get; private set; }
        public string End { get; private set; }
        public int Distance { get; private set; }
        public DateOnly Date { get; private set; }

        public Vehicle Vehicle { get; private set; }

        public Ride(int price, string beginning, string end, int distance, DateOnly date, Vehicle vehicle)
        {
            Price = price;
            Beginning = beginning;
            End = end;
            Distance = distance;
            Date = date;
            Vehicle = vehicle;
        }

        public void CancelRide()
        {
           //Naar Transportation center want die heeft alle Lists en info?
        }
    }
}
