using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCase2.Codes
{
    internal class Worker : Person
    {
        public EnumWorkType EnumWorkType { get; set; }
        public Worker(string firstName, string lastName, int tlfNummer, EnumWorkType workType) : base (firstName, lastName, tlfNummer)
        {
            EnumWorkType = workType;
        }

    }
}
