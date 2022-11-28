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

        public Worker martin = new("Martin", "Jensen", 11111111, EnumWorkType.bilMekaniker);
        public Worker thomas = new("Thomas", "Hansen", 22222222, EnumWorkType.motorcykelMekaniker);
        public Worker henrik = new("Henrik", "Nielsen", 33333333, EnumWorkType.lastbilMekaniker);
    }
}
