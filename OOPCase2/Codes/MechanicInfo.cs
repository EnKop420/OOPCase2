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
        public MechanicInfo(string firstName, string lastName, int tlfNummer, EnumMechanicType mechanicType) : base (firstName, lastName, tlfNummer)
        {
            EnumMechanicType = mechanicType;
        }
        public MechanicInfo()
        {

        }
    }
}
