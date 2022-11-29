using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OOPCase2.Codes
{
    internal class ServiceList
    {
        public VehicleInfo Vehicle { get; set; }
        public CustomerInfo Customers { get; set; }
        public List<ServiceList> Service { get; set; }

        public ServiceList(CustomerInfo customer, VehicleInfo vehicles)
        {
            Customers = customer;
            Vehicle = vehicles;
        }
        public ServiceList()
        {
            Service = new();
            Vehicle = new();
        }
    }
}
