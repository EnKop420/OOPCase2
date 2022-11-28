using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCase2.Codes
{
    internal class Customer : Person
    {

        public Car Car { get; set; }
        public Customer(string firstName, string lastName, int tlfNummer, Car cars) : base(firstName, lastName, tlfNummer)
        {
            Car = cars;
        }
        public EnumCarType? getCarType(string Input)
        {
            if (Input == EnumCarType.bil.ToString().ToLower())
            {
                return EnumCarType.bil;
            }
            else if (Input == EnumCarType.motorcykel.ToString().ToLower())
            {
                return EnumCarType.motorcykel;
            }
            else if(Input == EnumCarType.lastbil.ToString().ToLower())
            {
                return EnumCarType.lastbil;
            }

            return null;
        }
    }
}
