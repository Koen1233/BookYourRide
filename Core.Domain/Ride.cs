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
        public DateTime Date { get; private set; } //verandert van DateOnly

        public Vehicle Vehicle { get; private set; }

        public Cargo Cargo { get; private set; }

        public Ride(int price, string beginning, string end, int distance, DateTime date, Vehicle vehicle, Cargo cargo)
        {
            Price = price;
            Beginning = beginning;
            End = end;
            Distance = distance;
            Date = date;
            Vehicle = vehicle;
            Cargo = cargo;
        }



        //public override string ToString()
        //{
        //    return $"{Date} - {Beginning} to {End}";
        //}
    }
}
