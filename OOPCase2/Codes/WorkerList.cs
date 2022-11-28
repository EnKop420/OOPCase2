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

        public WorkerList(Customer customer, Worker worker)
        {
            Customers = customer;
            Workers = worker;
        }
        public WorkerList()
        {
            workerLists = new();
        }


        public void AddCustomer(WorkerList list)
        {
            workerLists.Add(list);
        }
    }
}
