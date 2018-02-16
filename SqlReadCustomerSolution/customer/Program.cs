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

            Customer c = new Customer();
            c.Name = "SuperDuperMax";
            c.City = "Mason";
            c.State = "OH";
            c.IsCorpAcct = true;
            c.CreditLimit = 1000000;
            c.Active = true;

            if (!cust.Insert(c)) 
            {
                Console.WriteLine("Insert Failed!");
            }
            List<Customer> customers = cust.List();
            //List<Customer> customers = cust.SearchByCreditLimitRange(300000, 1000000);
            foreach (Customer customer in customers)
            {
                Console.WriteLine($"| {customer.City} | {customer.State}| {customer.CreditLimit}");
            }
            
            Console.ReadKey();
        }
    }
}
