using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(System.Guid.NewGuid());
            DateTime mydate = DateTime.Now;
          //  DateTime mydate = new DateTime(2018, 12, 25);
          // DateTime my date = DateTime.Parse("2018/3/12");
            Console.WriteLine(mydate.AddDays(1));
            Console.ReadLine();

        }
        
    }
}
