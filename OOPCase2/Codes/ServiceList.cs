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
        public Mechanic Mechanics { get; set; }
        public Customer Customers { get; set; }
        public List<ServiceList> Service { get; set; }

        public ServiceList(Customer customer, Mechanic mechanic)
        {
            Customers = customer;
            Mechanics = mechanic;
        }
        public ServiceList()
        {
            Service = new();
            Mechanics = new();
        }
        public void AddCustomer(ServiceList list)
        {
            Service.Add(list);
        }
    }
}
