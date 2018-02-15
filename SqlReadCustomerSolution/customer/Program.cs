using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlReadCustomer;

namespace TestSqlReadCustomer
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerController cust = new CustomerController();
            //  List<Customer> customers = cust.List();
            List<Customer> customers = cust.SearchByCreditLimitRange(300000, 1000000);
            foreach (Customer customer in customers)
            {
                Console.WriteLine($"{customer.Id} | {customer.Name} | {customer.City} | {customer.State}| {customer.CreditLimit}");
            }
            //Customer customer = cust.Get(2);
            //Console.WriteLine($"{customer.Id} | {customer.Name} | {customer.City} | {customer.State}");
            Console.ReadKey();
        }
    }
}
