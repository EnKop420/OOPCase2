using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCase2.Codes
{
    internal class VehicleInfo
    {
        public EnumVehicleType? VehicleType { get; set; }
        public string VehiclePlate { get; set; }
        public string VehicleBrand { get; set; }
        public string VehicleModel { get; set; }
        public DateOnly VehicleYear { get; set; }
        public MechanicInfo Mechanic { get; set; }

        public MechanicInfo mechanicTypeFinder(EnumVehicleType? vehicleType)
        {
            if (vehicleType.Equals(EnumVehicleType.bil))
            {
                return new("Martin", "Jensen", 11111111, EnumMechanicType.bilMekaniker);
            }
            else if (VehicleType.Equals(EnumVehicleType.motorcykel))
            {
                return new("Thomas", "Hansen", 22222222, EnumMechanicType.motorcykelMekaniker);
            }
            else if(vehicleType.Equals(EnumVehicleType.lastbil))
            {
                return new("Henrik", "Nielsen", 33333333, EnumMechanicType.lastbilMekaniker);
            }
            throw new Exception($"Vi har ikke mekaniker som specialiserer sig i det du søger efter");
        }
        public VehicleInfo(EnumVehicleType? vehicleType, string vehiclePlate, string vehicleBrand, string vehicleModel, DateOnly vehicleYear)
        {
            VehicleType = vehicleType;
            VehiclePlate = vehiclePlate;
            VehicleBrand = vehicleBrand;
            VehicleModel = vehicleModel;
            VehicleYear = vehicleYear;
            Mechanic = mechanicTypeFinder(vehicleType);
        }
        public VehicleInfo()
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
        public MechanicInfo? getMechanic()
        {
            return Mechanic;
        }
    }
}
