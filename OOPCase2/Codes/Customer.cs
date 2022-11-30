using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCase2.Codes
{
    internal class CustomerInfo : Person
    {
        public CustomerInfo(string firstName, string lastName, int? tlfNummer) : base(firstName, lastName, tlfNummer)
        {

        }
        public CustomerInfo()
        {

        }
        public override List<string?> Search(List<ServiceList> SearchCustomer)
        {
            List<string?> result = new List<string?>();
            bool addonce = false;

            foreach (var item in SearchCustomer)
            {
                if (!addonce)
                {
                    if (item.Customers.FirstName.ToLower() == FirstName && item.Customers.LastName.ToLower() == LastName)
                    {
                        result.Add($"{item.Vehicle.Mechanic.EnumMechanicType.ToString().ToUpper()}: {item.Vehicle.Mechanic.FirstName} {item.Vehicle.Mechanic.LastName}\nMekanikeren arbejder på:\n-------------");
                        addonce = true;
                    }
                }
                if (item.Vehicle.Mechanic.FirstName == item.Vehicle.Mechanic.FirstName && item.Vehicle.Mechanic.LastName == item.Vehicle.Mechanic.LastName)
                {
                    result.Add($"Mærke: {item.Vehicle.VehicleBrand.ToString().ToUpper()}\nModel: {item.Vehicle.VehicleModel.ToString().ToUpper()}\nNummerplade: {item.Vehicle.VehiclePlate.ToString().ToUpper()}\nRegistrerings årgang: {item.Vehicle.VehicleYear.ToString()}\n-------------------");
                }

            }
            ////item.Vehicle.VehicleType.ToString().Equals(EnumVehicleType.bil.ToString())
            //foreach (var item in SearchCustomer)
            //{
            //    if (item.Vehicle.Mechanic.FirstName.ToLower() == item.Vehicle.Mechanic.FirstName.ToLower() && item.Vehicle.Mechanic.LastName.ToLower() == LastName)
            //    {
            //        result.Add($"Mærke: {item.Vehicle.VehicleBrand.ToString().ToUpper()}\nModel: {item.Vehicle.VehicleModel.ToString().ToUpper()}\nNummerplade: {item.Vehicle.VehiclePlate.ToString().ToUpper()}\nRegistrerings Aårgang: {item.Vehicle.VehicleYear.ToString()}");
            //    }
            //    //else if (item.Vehicle.VehicleType.ToString().Equals(EnumVehicleType.motorcykel.ToString()))
            //    //{
            //    //    result.Add($"Mærke: {item.Vehicle.VehicleBrand.ToString().ToUpper()}\nModel: {item.Vehicle.VehicleModel.ToString().ToUpper()}\nNummerplade: {item.Vehicle.VehiclePlate.ToString().ToUpper()}\nRegistrerings Aårgang: {item.Vehicle.VehicleYear.ToString()}");
            //    //}
            //    //else if (item.Vehicle.VehicleType.ToString().Equals(EnumVehicleType.lastbil.ToString()))
            //    //{
            //    //    result.Add($"Mærke: {item.Vehicle.VehicleBrand.ToString().ToUpper()}\nModel: {item.Vehicle.VehicleModel.ToString().ToUpper()}\nNummerplade: {item.Vehicle.VehiclePlate.ToString().ToUpper()}\nRegistrerings Aårgang: {item.Vehicle.VehicleYear.ToString()}");
            //    //}

            //}

            return result;

        }
    }
}
