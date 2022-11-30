using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCase2.Codes
{
    internal abstract class Person
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int? TlfNummer { get; set; }
        //public string Nummerplade { get; set; }

        public abstract List<string?> Search(List<ServiceList> enrollments);
        public Person(string? firstName, string? lastName, int? tlfNummer)
        {
            FirstName = firstName;
            LastName = lastName;
            TlfNummer = tlfNummer;
        }
        public Person()
        {

        }


    }

}
