using System;
namespace ClassMethodDemo
{
    public class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("{0} {1} added", customer.Name, customer.Surname);
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("{0} {1} deleted", customer.Name, customer.Surname);
        }

        public void List(Customer[] customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.Name + " " + customer.Surname);
            }
        }
    }
}
