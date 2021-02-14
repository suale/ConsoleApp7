using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer customer1 = new Customer();
            customer1.FirstName = "Ali";
            customer1.LastName = "Veli";
            customer1.CustomerId = 1;
            customer1.Balance = 1923;

            Customer customer2 = new Customer() { FirstName = "Ayşe", LastName = "Zeynep", Balance = 1990, CustomerId = 2 };

            CustomerManager musteriYoneticisi = new CustomerManager();

            musteriYoneticisi.AddCustomer(customer1);
            musteriYoneticisi.DeleteCustomer(customer2);

            Console.ReadLine();

        }
    }
}
