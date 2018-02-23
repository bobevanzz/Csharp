using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRStest
{
    class Program
    {
        static void Main(string[] args)
        {
            
            IntroDbContext db = new IntroDbContext();
            User[] users = db.Users.ToArray();
            foreach (User user in users)
            {
                string message = $"Name={user.FirstName} {user.LastName}";
                Console.WriteLine(message);
            }
            Console.ReadKey();
            //                        .Where(Customer=>Customer.State=="OH")
            //                        .OrderByDescending(cust => cust.State)
            //                        .ToArray();
        }
    }
}
