using Core.Domain.Helpers;
using Core.Domain.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Core.Domain
{
    public class Ride
    {
        public double Price { get; private set; } //Wordt berekend bij nieuwe ritten
        public string Beginning { get; private set; }
        public string End { get; private set; }
        public int Distance { get; private set; }
        public DateTime DateTime { get; private set; }

        public Vehicle Vehicle { get; private set; }

        public Cargo Cargo { get; private set; }

        //Complete constructor voor ophalen data vanuit de database
        public Ride(int price, string beginning, string end, int distance, DateTime dateTime, Vehicle vehicle, Cargo cargo)
        {
            Price = price;
            Beginning = beginning;
            End = end;
            Distance = distance;
            DateTime = dateTime;
            Vehicle = vehicle;
            Cargo = cargo;
        }

        //Constructor voor de UI laag zonder prijs waarin gecontroleerd wordt of de rit wel mogelijk is of niet
        public Ride(string beginning, string end, int distance, DateTime dateTime, Vehicle vehicle, Cargo cargo)
        {
            Price = this.CalcPrice();
            
            Beginning = beginning;
            End = end;
            Distance = distance;
            DateTime = dateTime;
            //Controleren of vehicle en cargo kloppen of dit in de klassen zelf doen?
            Vehicle = vehicle;
            Cargo = cargo;
        }
    }
}
