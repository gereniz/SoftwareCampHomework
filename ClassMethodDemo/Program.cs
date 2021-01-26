using System;
using System.Collections.Generic;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Name = "Ali";
            customer1.Surname = "Demir";
            customer1.CustomerNumber = "12345";

            Customer customer2 = new Customer();
            customer2.Name = "Ayşe";
            customer2.Surname = "Demir";
            customer2.CustomerNumber = "67890";

            Customer[] customers = new Customer[]
            {
                customer1,
                customer2
            };

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Delete(customer2);
            customerManager.List(customers);
        }
    }
}
