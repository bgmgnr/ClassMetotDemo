using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.Name+ " " + customer.Surname+" eklendi.");
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.Name + " " + customer.Surname + " silindi.");
        }

        public void List(List<Customer> customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Id +  ". " + customer.Name + " " + customer.Surname);
            }
        }







    }
}
