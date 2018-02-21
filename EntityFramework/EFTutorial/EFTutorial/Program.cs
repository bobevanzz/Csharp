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
            Customer[] customers = db.Customers.ToArray();
            foreach (Customer cust  in customers)
            {
                string message = $"Id={cust.Id}, Name ={cust.Name}";
                Console.WriteLine(message);
            }
            Console.ReadKey();
        }
        
    }
}
