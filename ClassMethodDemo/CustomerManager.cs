using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void AddCustomer(Customer customer)
        {
            Console.WriteLine("Customer {0} added successfully.",customer.FirstName);
        }
        public void DeleteCustomer(Customer customer)
        {
            Console.WriteLine("Customer {0} deleted successfully.",customer.FirstName);
        }
    }
}