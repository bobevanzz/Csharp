using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods    
{
    class ReferenceData
    {
        static void Main(string[] args)
        {  //using a reference to pass data to the pointer to return multiples pieces of data
            int x = 10;
            Console.WriteLine(x);
            DoubleIt(ref x);
            Console.WriteLine(x);
            Console.ReadLine();
            int price = 125; //beginning of out data
            int qty = 50;
            int result;
            bool success = DoCalc(price, qty, out result);
        }
        static bool DoCalc(int x, int y, out int z) //using out to pass data
        {
            z = x * y;
            return true;
        }
        static void DoubleIt(ref int val) {  // reference data
            val = val * 2;
        }
    }
}
