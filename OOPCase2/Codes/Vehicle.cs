using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCase2.Codes
{
    internal class Vehicle
    {
        public EnumVehicleType? VehicleType { get; set; }
        public string VehiclePlate { get; set; }
        public string VehicleBrand { get; set; }
        public string VehicleModel { get; set; }
        public DateOnly VehicleYear { get; set; }
        public Vehicle(EnumVehicleType? vehicleType, string vehiclePlate, string vehicleBrand, string vehicleModel, DateOnly vehicleYear)
        {
            VehicleType = vehicleType;
            VehiclePlate = vehiclePlate;
            VehicleBrand = vehicleBrand;
            VehicleModel = vehicleModel;
            VehicleYear = vehicleYear;
        }
        public Vehicle()
        {
        }
        public EnumVehicleType? getVehicleType(string Input)
        {
            if (Input == EnumVehicleType.bil.ToString().ToLower())
            {
                return EnumVehicleType.bil;
            }
            else if (Input == EnumVehicleType.motorcykel.ToString().ToLower())
            {
                return EnumVehicleType.motorcykel;
            }
            else if (Input == EnumVehicleType.lastbil.ToString().ToLower())
            {
                return EnumVehicleType.lastbil;
            }
            return null;
        }
    }
}
