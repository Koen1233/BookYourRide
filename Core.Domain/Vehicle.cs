﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain
{
    public class Vehicle
    {
        public int Mileage { get; private set; } // int ranging from 0 to 100 (100%)
        public int WriteOff {  get; private set; } //KM
        public int MaxLoad { get; private set; }//Kilo's
        public int PassengerSeats {  get; private set; }
        public bool Status {  get; private set; }
        public VehicleType VehicleType { get; private set; }



        public Vehicle(int mileage, int writeOff, int Maxload, int passengerSeats, bool status, VehicleType vehicleType)
        {
            Mileage = mileage;
            WriteOff = writeOff;
            MaxLoad = Maxload;
            PassengerSeats = passengerSeats;
            Status = status;
            VehicleType = vehicleType;
        }
    }
}
