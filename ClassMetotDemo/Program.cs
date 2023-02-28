using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Id = 123;
            customer.Name = "Test1";
            customer.Surname = "Test12";

            Customer customer1 = new Customer();
            customer1.Id = 321;
            customer1.Name = "Test2";
            customer1.Surname = "Test23";

            Customer[] customers = new Customer[] { customer, customer1 };

            foreach (var item in customers)
            {
                Console.WriteLine("Customer ID :" + item.Id);
                Console.WriteLine("Customer Name :" + item.Name);
                Console.WriteLine("Customer Surname :" + item.Surname);

                Console.WriteLine("----------------------");
            }

            AddCustomer addCustomer = new AddCustomer();

            addCustomer.CustomerAdd(customer);
            addCustomer.CustomerAdd(customer1);

            Console.WriteLine("List Metodu");
            addCustomer.ListAdd(customer);
            addCustomer.ListAdd(customer1);

            Console.WriteLine("Delete Metedu");
            addCustomer.CustomerDelete(customer);
            addCustomer.CustomerDelete(customer1);

        }
    }

}