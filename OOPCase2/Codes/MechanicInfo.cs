using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCase2.Codes
{
    internal class MechanicInfo : Person
    {
        public EnumMechanicType EnumMechanicType { get; set; }
        public MechanicInfo(string firstName, string lastName, int tlfNummer, EnumMechanicType mechanicType) : base(firstName, lastName, tlfNummer)
        {
            EnumMechanicType = mechanicType;
        }
        public MechanicInfo()
        {

        }
        public override List<string?> Search(List<ServiceList> SearchMechanic)
        {
            List<string?> result = new List<string?>();
            bool addOnce = false;
            foreach (var item in SearchMechanic)
            {
                if (item.Vehicle.Mechanic.FirstName.ToLower() == FirstName && item.Vehicle.Mechanic.LastName.ToLower() == LastName)
                {
                    if (!addOnce)
                    {
                    result.Add($"{item.Vehicle.Mechanic.EnumMechanicType.ToString().ToUpper()}: {item.Vehicle.Mechanic.FirstName} {item.Vehicle.Mechanic.LastName}\n---------------\nKunder: {item.Customers.FirstName} {item.Customers.LastName}");
                    }
                    result.Add($"Mærke: {item.Vehicle.VehicleBrand.ToString().ToUpper()}\nModel: {item.Vehicle.VehicleModel.ToString().ToUpper()}\nNummerplade: {item.Vehicle.VehiclePlate.ToString().ToUpper()}\nRegistrerings Aårgang: {item.Vehicle.VehicleYear.ToString()}\nEjerens Telefonnummer: {item.Customers.TlfNummer.ToString()}\n----------");
                    addOnce = true;

                }

            }
            return result;

        }
    }
}
