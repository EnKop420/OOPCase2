using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCase2.Codes
{
    internal class Car
    {
        public EnumCarType BilType { get; set; }
        public string NummerPlade { get; set; }
        public string BilMærke { get; set; }
        public string BilModel { get; set; }
        public DateOnly BilÅrgang { get; set; }
        public Car(EnumCarType carType, string nummerPlade, string bilMærke, string bilModel, DateOnly bilÅrgang)
        {
            BilType = carType;
            NummerPlade = nummerPlade;
            BilMærke = bilMærke;
            BilModel = bilModel;
            BilÅrgang = bilÅrgang;
        }
        public Car()
        {
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
            else if (Input == EnumCarType.lastbil.ToString().ToLower())
            {
                return EnumCarType.lastbil;
            }
            return null;
        }
    }
}
