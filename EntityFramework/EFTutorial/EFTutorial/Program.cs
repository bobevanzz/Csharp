using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            IntroDbContext db = new IntroDbContext();

            Order[] orders = db.Orders.ToArray();
            foreach (Order order in orders)
            {
                string message= $"Id={order.Id}, Total={order.Total}, Cust={order.Customer.Name}" ;
                Console.WriteLine(message);
            }


            ////find customers where state is ohio descending
            //Customer[] customers = db.Customers
            //                        .Where(Customer=>Customer.State=="OH")
            //                        .OrderByDescending(cust => cust.State)
            //                        .ToArray();
            //foreach (Customer cust in customers)
            //{
            //    string message = $"Id={cust.Id}, Name ={cust.Name}, City/St={cust.City},{cust.State}";
            //    Console.WriteLine(message);
            //}

            //Customer Chris = db.Customers.Find(5);  // find one customer
            //if (Chris==null)
            //{
            //    Console.WriteLine("couldn't find Chris");
            //}
            //else
            //{
            //    string message = $"Id={Chris.Id}, Name ={Chris.Name}, City/St={Chris.City},{Chris.State}";
            //    Console.WriteLine(message);
            //}
            //Customer[] custs = db.Customers.Where(Cust => Cust.Name == "Greg"&& Cust.State=="OH").ToArray();
            //foreach (Customer cust in custs)
            //{
            //    string message = $"Name={cust.Name}, City/St={cust.City},{cust.State}";
            //    Console.WriteLine(message);
            //}

            Console.ReadKey();
        }
        
    }
}
