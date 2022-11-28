using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OOPCase2.Codes
{
    internal class WorkerList
    {
        public Worker Workers { get; set; }
        public Customer Customers { get; set; }
        public List<WorkerList> workerLists { get; set; }

        public WorkerList(Worker worker, Customer customer)
        {
            Workers = worker;
            Customers = customer;
        }
        public WorkerList()
        {

        }


        public void AddCustomer(string FirstName, string LastName, int tlfNummer, )
        {
        }
    }
}
