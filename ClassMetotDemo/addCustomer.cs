using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class AddCustomer
    {
        public void CustomerAdd(Customer customers)
        {
            Console.WriteLine("Customer ID :" + customers.Id);
            Console.WriteLine("Customer Name :" + customers.Name);
            Console.WriteLine("Customer Surname :" + customers.Surname);

            Console.WriteLine("----------------------");
        }

        public void ListAdd(Customer customers)
        {
            Console.WriteLine("Yeni Musteri Eklendi" + customers.Name);
        }

        public void CustomerDelete(Customer customers)
        {
            Console.WriteLine("Musteri Silindi" + customers.Name);
        }
    }
}
