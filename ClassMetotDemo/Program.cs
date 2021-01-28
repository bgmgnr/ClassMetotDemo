using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Begum";
            customer1.Surname = "Guner";
            customer1.Tc = "123456789";
            customer1.BirthDate = "03.07.2000";

            Customer customer2 = new Customer();
            customer2.Id = 1;
            customer2.Name = "Anday";
            customer2.Surname = "Aktaş";
            customer2.Tc = "123656589";
            customer2.BirthDate = "18.10.1999";

            List<Customer> customers = new List<Customer>() { customer1, customer2 };
            CustomerManager customerManager = new CustomerManager();
            Customer customer = new Customer();

            // customerManager.Add(customer1);
            // customerManager.Add(customer2);

            customerManager.Delete(customer1);
            customers.Remove(customer1);

            customerManager.List(customers);





        }
    }
}
