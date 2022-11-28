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
    }
}
