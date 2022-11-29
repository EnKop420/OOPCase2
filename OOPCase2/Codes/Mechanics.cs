using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCase2.Codes
{
    internal class Mechanic : Person
    {
        public EnumMechanicType EnumMechanicType { get; set; }
        public Mechanic(string firstName, string lastName, int tlfNummer, EnumMechanicType mechanicType) : base (firstName, lastName, tlfNummer)
        {
            EnumMechanicType = mechanicType;
        }
        public Mechanic()
        {

        }
        public Mechanic? GetWorker(EnumVehicleType carType)
        {
            Mechanic martin = new("Martin", "Jensen", 11111111, EnumMechanicType.bilMekaniker);
            Mechanic thomas = new("Thomas", "Hansen", 22222222, EnumMechanicType.motorcykelMekaniker);
            Mechanic henrik = new("Henrik", "Nielsen", 33333333, EnumMechanicType.lastbilMekaniker);
            if (carType.Equals(EnumVehicleType.bil))
            {
            return martin;
            }
            else if (carType.Equals(EnumVehicleType.motorcykel))
            {
                return thomas;
            }
            else if (carType.Equals(EnumVehicleType.lastbil))
            {
                return henrik;
            }
            throw new Exception("Kunne ikke finde en mekaniker til dit køretøj");
        }
    }
}
